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
        private readonly BookingsService _bookingsService;
        private readonly GuestService _guestService;
        public Frm_Rezervasyon()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var _roomRepo = new RoomRepository(dbContext);
            _roomService = new RoomService(_roomRepo);

            var _rRepo = new RoomTypeRepository(dbContext);
            _roomTypeService = new RoomTypeService(_rRepo);


            var _hotelRepo = new HotelRepository(dbContext);
            _hotelService = new HotelService(_hotelRepo);

            var _bookingRepo = new BookingsRepository(dbContext);
            _bookingsService = new BookingsService(_bookingRepo);

            var _guestRepo = new GuestRepository(dbContext);
            _guestService = new GuestService(_guestRepo);
        }

        private void Frm_Rezervasyon_Load(object sender, EventArgs e)
        {
            GetAllHotel();

            GetAllBooking();
        }

        private void GetAllHotel()
        {
            cmbOtel.ValueMember = "Id";
            cmbOtel.DisplayMember = "FullName";
            cmbOtel.DataSource = _hotelService.GetAll();
        }

        private void GetAllRoomType(Guid Id)
        {
            var roomTypes = _roomTypeService.GetByID(Id);
            cmbRoomType.DataSource = roomTypes;
        }

        private void GetAllRoom(Guid Id)
        {
            var rooms = _roomService.GetByID(Id);
            cmbRoom.DataSource = rooms;
        }

        private void GetAllBooking()
        {
            dgwRez.DataSource = _bookingsService.GetAll();
        }

        Hotel secilenOtel;
        private void cmbOtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOtel.SelectedIndex != -1)
            {
                secilenOtel = (Hotel)cmbOtel.SelectedItem;
                GetAllRoom(secilenOtel.Id);
            }
        }

        RoomType secilenRoomType;
        private void cmbRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cmbOtel.SelectedIndex != -1)
            //{
            //    secilenRoomType = (RoomType)cmbRoomType.SelectedItem;
            //    GetAllRoom(secilenRoomType.Id);
            //}
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }
    }
}
