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
    public partial class Frm_Misafir : Form
    {
        private readonly GuestService _guestService;
        private readonly BookingGuestService _bookingGuestService;
        private Guid _bookingId;
        private int _misafirSayisi;
        public Frm_Misafir(int misafirSayisi, Guid bookingId)
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var _gRepo = new GuestRepository(dbContext);
            _guestService = new GuestService(_gRepo);

            var _bgRepo = new BookingGuestRepository(dbContext);
            _bookingGuestService = new BookingGuestService(_bgRepo);

            _misafirSayisi = misafirSayisi;
            _bookingId = bookingId;

            CreateGuestEntries(_misafirSayisi);

        }

        // Misafir girişlerini dinamik olarak oluştur
        private void CreateGuestEntries(int misafirSayisi)
        {
            for (int i = 0; i < misafirSayisi; i++)
            {
                // Misafir bilgisi giriş alanları
                Label lblAd = new Label()
                {
                    Text = $"Adı ({i + 1}):",
                    Location = new System.Drawing.Point(50, 50 + (i * 60)),
                    AutoSize = true
                };
                TextBox txtAd = new TextBox()
                {
                    Name = $"txtAd{i}",
                    Location = new System.Drawing.Point(150, 50 + (i * 60)),
                    Size = new System.Drawing.Size(200, 20)
                };

                Label lblSoyad = new Label()
                {
                    Text = $"Soyadı ({i + 1}):",
                    Location = new System.Drawing.Point(50, 90 + (i * 60)),
                    AutoSize = true
                };
                TextBox txtSoyad = new TextBox()
                {
                    Name = $"txtSoyad{i}",
                    Location = new System.Drawing.Point(150, 90 + (i * 60)),
                    Size = new System.Drawing.Size(200, 20)
                };

                // Kontrolleri forma ekle
                this.Controls.Add(lblAd);
                this.Controls.Add(txtAd);
                this.Controls.Add(lblSoyad);
                this.Controls.Add(txtSoyad);
            }
        }

        private void Frm_Misafir_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {

                // Misafir bilgilerini al
                List<Guest> guests = new List<Guest>();
                for (int i = 0; i < _misafirSayisi; i++)
                {
                    Guest guest = new Guest()
                    {
                        Id = Guid.NewGuid(),
                        FirstName = txtAd.Text,
                        LastName = txtSoyad.Text,
                        TCKN = txtTCKN.Text,
                        DateOfBirth = dtpDateOfBirth.Value,
                        Address = txtAdres.Text,
                        Phone = txtTel.Text,
                        Email = txtMail.Text,
                        IsActive = true,
                        CreatedDate = DateTime.Now
                    };

                    _misafirSayisi--;
                    guests.Add(guest);
                    
                }

                // Guest ve BookingGuest kayıtlarını oluştur
                foreach (var guest in guests)
                {
                    _guestService.Create(guest);

                    var bookingGuest = new BookingGuest
                    {
                        Id = Guid.NewGuid(),
                        BookingID = _bookingId,
                        GuestID = guest.Id
                    };

                    _bookingGuestService.Create(bookingGuest);
                }
                MessageBox.Show("Misafir başarıyla kaydedildi!");

                // TextBox'ları temizle
                ClearTextBoxes();

                // Tüm misafirler girildiyse formu kapat
                if (_misafirSayisi <= 0)
                {
                    MessageBox.Show("Tüm misafirler kaydedildi.");
                    this.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearTextBoxes()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTCKN.Clear();
            dtpDateOfBirth.Value = DateTime.Now;
            txtAdres.Clear();
            txtTel.Clear();
            txtMail.Clear();
        }
    }
}
