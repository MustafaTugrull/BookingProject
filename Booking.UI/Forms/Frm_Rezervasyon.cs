using Booking.Business.Service;
using Booking.DataAccess.Context;
using Booking.DataAccess.Repository;
using Booking.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Booking.UI.Forms
{
    public partial class Frm_Rezervasyon : Form
    {
        private readonly RoomService _roomService;
        private readonly RoomTypeService _roomTypeService;
        private readonly HotelService _hotelService;
        private readonly BookingGuestService _bookingGuestService;
        private readonly BookingsService _bookingsService;
        private readonly GuestService _guestService;
        private List<Room> _selectedHotels = new();

        public Frm_Rezervasyon()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var _roomRepo = new RoomRepository(dbContext);
            _roomService = new RoomService(_roomRepo);

            var _rRepo = new RoomTypeRepository(dbContext);
            _roomTypeService = new RoomTypeService(_rRepo);

            var _bgRepo = new BookingGuestRepository(dbContext);
            _bookingGuestService = new BookingGuestService(_bgRepo);

            var _hotelRepo = new HotelRepository(dbContext);
            _hotelService = new HotelService(_hotelRepo);

            var _bookingRepo = new BookingsRepository(dbContext);
            _bookingsService = new BookingsService(_bookingRepo);

            var _guestRepo = new GuestRepository(dbContext);
            _guestService = new GuestService(_guestRepo);
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            if (cmbRoomType.SelectedValue == null)
            {
                lblTotal.Text = "0 TL";
                return;
            }

            var selectedRoomTypeId = (Guid)cmbRoomType.SelectedValue;
            var roomType = _roomTypeService.GetByID(selectedRoomTypeId);

            if (roomType == null)
            {
                lblTotal.Text = "0 TL";
                return;
            }

            int totalDays = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
            if (totalDays <= 0)
            {
                lblTotal.Text = "0 TL";
                return;
            }

            decimal totalPrice = roomType.PricePerNight * totalDays;
            lblTotal.Text = $"{totalPrice} TL";
        }

        private void Frm_Rezervasyon_Load(object sender, EventArgs e)
        {
            GetAllHotel();
            GetAllBooking();

            dtpCheckIn.ValueChanged += dtp_ValueChanged;
            dtpCheckOut.ValueChanged += dtp_ValueChanged;
            cmbRoomType.SelectedIndexChanged += cmbRoomType_SelectedIndexChanged;
        }

        private void GetAllHotel()
        {
            cmbOtel.ValueMember = "Id";
            cmbOtel.DisplayMember = "FullName";
            cmbOtel.DataSource = _hotelService.GetAll();
        }

        private void GetAllRoomType(Guid selectedHotelId)
        {


            var rooms = _roomService.GetAll()
                                    .Where(c => c.HotelID == selectedHotelId)
                                    .ToList();

            var roomTypes = rooms.Select(r => _roomTypeService.GetAll()
                                                             .FirstOrDefault(rt => rt.Id == r.RoomTypeID))
                                 .Distinct()
                                 .ToList();

            cmbRoomType.DisplayMember = "Name";
            cmbRoomType.ValueMember = "Id";
            cmbRoomType.DataSource = roomTypes;
        }



        private void GetAllBooking()
        {
            dgwRez.DataSource = _bookingsService.GetAll();
        }

        private void cmbOtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOtel.SelectedIndex != -1 && cmbOtel.SelectedValue != null)
            {
                var selectedHotelId = (Guid)cmbOtel.SelectedValue;
                GetAllRoomType(selectedHotelId);
            }
        }

        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }

        //private bool IsRoomAvailable(Guid roomId, DateTime checkIn, DateTime checkOut)
        //{
        //    var bookings = _bookingsService.GetAll().Where(b => b.RoomID == roomId && b.IsActive).ToList();

        //    foreach (var booking in bookings)
        //    {
        //        // Eğer rezervasyonların tarihlerine denk gelen bir rezervasyon varsa oda doludur.
        //        if ((checkIn >= booking.CheckinDate && checkIn < booking.CheckoutDate) ||
        //            (checkOut > booking.CheckinDate && checkOut <= booking.CheckoutDate) ||
        //            (checkIn <= booking.CheckinDate && checkOut >= booking.CheckoutDate))
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}

        private Room FindAvailableRoom(Guid roomTypeId, DateTime checkIn, DateTime checkOut)
        {
            // Belirtilen oda tipi için uygun tüm odaları al
            var rooms = _roomService.GetAll()
                                    .Where(r => r.RoomTypeID == roomTypeId)
                                    .ToList();

            // Müsait olan odaları bul
            var availableRooms = rooms.Where(r =>
                !_bookingsService.GetAll()
                .Any(b =>
                    b.RoomID == r.Id &&
                    ((checkIn >= b.CheckinDate && checkIn < b.CheckoutDate) ||
                    (checkOut > b.CheckinDate && checkOut <= b.CheckoutDate) ||
                    (checkIn <= b.CheckinDate && checkOut >= b.CheckoutDate))
                )).ToList();

            if (availableRooms.Count == 0)
            {
                return null; // Müsait oda yok
            }

            // Rastgele bir oda seç
            Random rand = new Random();
            int index = rand.Next(availableRooms.Count);
            return availableRooms[index];
        }

        private void nmrSayi_ValueChanged(object sender, EventArgs e)
        {
            // Oda tipi seçildi mi ve kişi sayısı belirtildi mi?
            if (cmbRoomType.SelectedIndex != -1 && cmbRoomType.SelectedValue != null && nmrSayi.Value > 0)
            {
                var selectedRoomTypeId = (Guid)cmbRoomType.SelectedValue;
                var roomType = _roomTypeService.GetByID(selectedRoomTypeId);

                if (roomType != null)
                {
                    // Seçilen oda tipinin kapasitesi aşıldı mı?
                    if (nmrSayi.Value > roomType.Capacity)
                    {
                        MessageBox.Show($"Bu oda tipi en fazla {roomType.Capacity} kişiliktir.");
                        nmrSayi.Value = roomType.Capacity; // Kişi sayısını kapasiteye eşitler
                    }
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                // Otel ve oda tipi seçildi mi?
                if (cmbOtel.SelectedIndex == -1 || cmbOtel.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir otel seçin.");
                    return;
                }
                if (cmbRoomType.SelectedIndex == -1 || cmbRoomType.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen bir oda tipi seçin.");
                    return;
                }

                var selectedRoomTypeId = (Guid)cmbRoomType.SelectedValue;
                var roomType = _roomTypeService.GetByID(selectedRoomTypeId);

                if (roomType == null)
                {
                    MessageBox.Show("Oda tipi bilgisi alınırken bir hata oluştu.");
                    return;
                }

                // Kişi sayısının oda kapasitesini aşmadığını kontrol et
                if (nmrSayi.Value > roomType.Capacity)
                {
                    MessageBox.Show($"Bu oda tipi en fazla {roomType.Capacity} kişiliktir.");
                    return;
                }

                // Seçilen oda tipine uygun rastgele bir oda bulun
                DateTime checkIn = dtpCheckIn.Value;
                DateTime checkOut = dtpCheckOut.Value;
                var room = FindAvailableRoom(selectedRoomTypeId, checkIn, checkOut);

                if (room == null)
                {
                    MessageBox.Show("Seçilen tarihlerde bu oda tipine uygun boş oda bulunmamaktadır. Lütfen farklı tarihler deneyin.");
                    return;
                }

                int totalDays = (checkOut - checkIn).Days;
                if (totalDays <= 0)
                {
                    MessageBox.Show("Geçerli bir tarih aralığı seçin.");
                    return;
                }

                decimal totalPrice = roomType.PricePerNight * totalDays;

                var newBooking = new Bookings
                {
                    Id = Guid.NewGuid(),
                    CheckinDate = checkIn,
                    CheckoutDate = checkOut,
                    RoomID = room.Id,
                    TotalPrice = totalPrice,
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Room = room
                };

                _bookingsService.Create(newBooking);
                GetAllBooking();

                Frm_Misafir misafirForm = new Frm_Misafir((int)nmrSayi.Value, newBooking.Id);
                misafirForm.ShowDialog();
                MessageBox.Show("Rezervasyon başarıyla kaydedildi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rezervasyon kaydedilirken bir hata oluştu: " + ex.Message);
            }
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dgwRez.SelectedRows.Count == 0) return;

            try
            {
                var selectedRow = dgwRez.SelectedRows[0];
                var bookingId = (Guid)selectedRow.Cells["Id"].Value;
                var booking = _bookingsService.GetByID(bookingId);

                if (booking != null)
                {
                    // Güncellenmiş bilgileri al
                    booking.CheckinDate = dtpCheckIn.Value;
                    booking.CheckoutDate = dtpCheckOut.Value;

                    var selectedRoomTypeId = (Guid)cmbRoomType.SelectedValue;
                    var roomType = _roomTypeService.GetByID(selectedRoomTypeId);

                    if (roomType == null)
                    {
                        MessageBox.Show("Oda tipi bilgisi alınırken bir hata oluştu.");
                        return;
                    }

                    // Kişi sayısının oda kapasitesini aşmadığını kontrol et
                    if (nmrSayi.Value > roomType.Capacity)
                    {
                        MessageBox.Show($"Bu oda tipi en fazla {roomType.Capacity} kişiliktir.");
                        return;
                    }

                    // Yeni oda seçimini yap
                    var room = FindAvailableRoom(selectedRoomTypeId, dtpCheckIn.Value, dtpCheckOut.Value);

                    if (room == null)
                    {
                        MessageBox.Show("Seçilen tarihlerde bu oda tipine uygun boş oda bulunmamaktadır. Lütfen farklı tarihler deneyin.");
                        return;
                    }

                    booking.RoomID = room.Id; // Yeni oda ID'si
                    booking.TotalPrice = roomType.PricePerNight * (dtpCheckOut.Value - dtpCheckIn.Value).Days;

                    // Güncellenmiş rezervasyonu kaydet
                    _bookingsService.Update(booking);
                    GetAllBooking();
                    MessageBox.Show("Rezervasyon başarıyla güncellendi!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgwRez.SelectedRows.Count == 0) return;

            try
            {
                var bookingId = (Guid)dgwRez.SelectedRows[0].Cells["Id"].Value;

                // Bu rezervasyona ait misafirleri al
                var bookingGuests = _bookingGuestService.GetAll().Where(bg => bg.BookingID == bookingId).ToList();

                // Her bir misafiri sil
                foreach (var bookingGuest in bookingGuests)
                {
                    _guestService.Delete(bookingGuest.GuestID);
                }

                // Rezervasyonu sil
                _bookingsService.Delete(bookingId);

                // Tabloları yenile
                GetAllBooking();
                MessageBox.Show("Rezervasyon ve misafirler başarıyla silindi!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgwRez_SelectionChanged(object sender, EventArgs e)
        {
            if (dgwRez.SelectedRows.Count > 0)
            {
                var selectedRow = dgwRez.SelectedRows[0];
                var bookingId = (Guid)selectedRow.Cells["Id"].Value;
                var booking = _bookingsService.GetByID(bookingId);

                if (booking != null)
                {
                    // Rezervasyon bilgilerini formdaki alanlara doldur
                    cmbOtel.SelectedValue = booking.Room.HotelID;
                    cmbRoomType.SelectedValue = booking.Room.RoomTypeID;
                    dtpCheckIn.Value = booking.CheckinDate;
                    dtpCheckOut.Value = booking.CheckoutDate;
                    nmrSayi.Value = booking.Room.RoomType.Capacity; // ya da uygun bir başka veri

                    // Misafir listesini güncelle
                    UpdateGuestList(bookingId);
                }
            }
        }

        private void UpdateGuestList(Guid bookingId)
        {
            var bookingGuests = _bookingGuestService.GetAll().Where(bg => bg.BookingID == bookingId).ToList();
            var guestIds = bookingGuests.Select(bg => bg.GuestID).ToList();
            var guests = _guestService.GetAll().Where(g => guestIds.Contains(g.Id)).ToList();

            lstMisafir.Items.Clear();
            foreach (var guest in guests)
            {
                lstMisafir.Items.Add(guest); // ya da uygun bir başka özellik
            }
        }

        private Guid GetSelectedBookingId()
        {
            if (dgwRez.SelectedRows.Count > 0)
            {
                return (Guid)dgwRez.SelectedRows[0].Cells["Id"].Value;
            }
            return Guid.Empty; // veya uygun bir hata durumu işleme
        }

        Guest secilen;
        private void lstMisafir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMisafir.SelectedIndex != -1)
            {
                secilen = (Guest)lstMisafir.SelectedItem;
                txtAd.Text = secilen.FirstName;
                txtSoyad.Text = secilen.LastName;
                txtTCKN.Text = secilen.TCKN;
                dtpDateOfBirth.Value = secilen.DateOfBirth;
                txtAdres.Text = secilen.Address;
                txtTel.Text = secilen.Phone;
                txtMail.Text = secilen.Email;
            }
        }

        private void btnGuestUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                secilen.FirstName = txtAd.Text;
                secilen.LastName = txtSoyad.Text;
                secilen.TCKN = txtTCKN.Text;
                secilen.DateOfBirth = dtpDateOfBirth.Value;
                secilen.Address = txtAdres.Text;
                secilen.Phone = txtTel.Text;
                secilen.Email = txtMail.Text;

                _guestService.Update(secilen);
                MessageBox.Show("Güncelleme Başarılı.");

                UpdateGuestList(GetSelectedBookingId());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuestDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstMisafir.SelectedIndex != -1)
                {
                    var selectedGuest = (Guest)lstMisafir.SelectedItem;
                    _guestService.Delete(selectedGuest.Id);
                    MessageBox.Show("Misafir başarıyla silindi.");

                    // Silme işleminden sonra misafir listesini yenile
                    var bookingId = GetSelectedBookingId();
                    UpdateGuestList(bookingId);

                    // Rezervasyonun tüm misafirleri silinmiş mi kontrol et
                    var remainingGuests = _bookingGuestService.GetAll().Where(bg => bg.BookingID == bookingId).ToList();
                    if (remainingGuests.Count == 0)
                    {
                        _bookingsService.Delete(bookingId);
                        MessageBox.Show("Tüm misafirler silindiği için rezervasyon silindi.");
                        GetAllBooking(); // Rezervasyon listesini yenile
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
