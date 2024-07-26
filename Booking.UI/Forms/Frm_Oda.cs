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
    public partial class Frm_Oda : Form
    {
        private readonly RoomService _roomService;
        private readonly RoomTypeService _roomTypeService;
        private readonly HotelService _hotelService;
        public Frm_Oda()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var _roomRepo = new RoomRepository(dbContext);
            _roomService = new RoomService(_roomRepo);

            var _roomTypeRepo = new RoomTypeRepository(dbContext);
            _roomTypeService = new RoomTypeService(_roomTypeRepo);

            var _hotelRepo = new HotelRepository(dbContext);
            _hotelService = new HotelService(_hotelRepo);

        }

        private void Frm_Oda_Load(object sender, EventArgs e)
        {
            GetAllHotel();
            GetAllRoomType();
            GetAllRoom();

        }

        private void GetAllRoomType()
        {
            cmbOdaTip.ValueMember = "Id";
            cmbOdaTip.DisplayMember = "Name";
            cmbOdaTip.DataSource = _roomTypeService.GetAll();
        }

        private void GetAllHotel()
        {
            cmbOtel.ValueMember = "Id";
            cmbOtel.DisplayMember = "FullName";
            cmbOtel.DataSource = _hotelService.GetAll();
        }

        private void GetAllRoom()
        {
            lstOda.ValueMember = "Id";
            lstOda.DisplayMember = "FullName";
            lstOda.DataSource = _roomService.GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Room newRoom = new Room()
                {
                    Id = Guid.NewGuid(),
                    Hotel = secilenOtel,
                    RoomType = secilenOdaTip,
                    RoomNumber = (int)nmrOdaNo.Value,
                    Status = chkActive.Checked,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                };

                _roomService.Create(newRoom);
                MessageBox.Show("Kayıt Başarılı");
                GetAllRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                secilen.Hotel = secilenOtel;
                secilen.RoomType = secilenOdaTip;
                secilen.RoomNumber=(int)nmrOdaNo.Value;
                secilen.Status = chkActive.Checked;

                _roomService.Update(secilen);
                MessageBox.Show("Güncelleme Başarılı");
                GetAllRoom();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstOda.SelectedIndex != -1)
                {
                    Guid id = (Guid)lstOda.SelectedValue;
                    _roomService.Delete(id);
                    GetAllRoom();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        Hotel secilenOtel;
        private void cmbOdaAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOtel.SelectedIndex != -1)
            {
                secilenOtel = (Hotel)cmbOtel.SelectedItem;
            }

        }

        RoomType secilenOdaTip;
        private void cmbOdaTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOdaTip.SelectedIndex != -1)
            {
                secilenOdaTip = (RoomType)cmbOdaTip.SelectedItem;
            }
        }

        Room secilen;
        private void lstOda_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOda.SelectedIndex != -1)
            {
                secilen = (Room)lstOda.SelectedItem;
                cmbOtel.Text = secilenOdaTip.ToString();
                cmbOdaTip.Text = secilenOdaTip.ToString();
                nmrOdaNo.Value = secilen.RoomNumber;
                chkActive.Checked = secilen.Status;

            }
        }
    }
}
