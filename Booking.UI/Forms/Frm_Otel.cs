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
    public partial class Frm_Otel : Form
    {
        private readonly HotelService _hotelService;
        public Frm_Otel()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var _hRepo = new HotelRepository(dbContext);
            _hotelService = new HotelService(_hRepo);

        }

        private void Frm_Otel_Load(object sender, EventArgs e)
        {
            GetAllHotel();
        }

        private void GetAllHotel()
        {
            lstOtel.ValueMember = "Id";
            lstOtel.DisplayMember = "FullName";
            lstOtel.DataSource = _hotelService.GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Hotel newOtel = new Hotel()
                {
                    Id = Guid.NewGuid(),
                    Name = txtAd.Text,
                    Address = txtAdres.Text,
                    Phone = txtTel.Text,
                    Email = txtMail.Text,
                    Stars = (int)nmrYildiz.Value,
                    CheckinTime = dtpCheckIn.Value.TimeOfDay,
                    CheckoutTime = dtpCheckOut.Value.TimeOfDay,
                    IsActive = chkActive.Checked,
                    CreatedDate = DateTime.Now

                };

                _hotelService.Create(newOtel);
                MessageBox.Show("Kayıt Başarılı");
                GetAllHotel();
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
                secilen.Name = txtAd.Text;
                secilen.Address = txtAdres.Text;
                secilen.Phone = txtTel.Text;
                secilen.Email = txtMail.Text;
                secilen.Stars = (int)nmrYildiz.Value;
                secilen.CheckinTime = dtpCheckIn.Value.TimeOfDay;
                secilen.CheckoutTime = dtpCheckOut.Value.TimeOfDay;
                secilen.IsActive = chkActive.Checked;

                _hotelService.Update(secilen);
                MessageBox.Show("Güncelleme Başarılı.");
                GetAllHotel();
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
                if (lstOtel.SelectedIndex != -1)
                {
                    Guid id = (Guid)lstOtel.SelectedValue;
                    _hotelService.Delete(id);
                    GetAllHotel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        Hotel secilen;
        private void lstOtel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOtel.SelectedIndex != -1)
            {
                secilen = (Hotel)lstOtel.SelectedItem;
                txtAd.Text = secilen.Name;
                txtAdres.Text = secilen.Address;
                txtTel.Text = secilen.Phone;
                txtMail.Text = secilen.Email;
                nmrYildiz.Value = secilen.Stars;
                dtpCheckIn.Value = DateTime.Today.Add(secilen.CheckinTime);
                dtpCheckOut.Value = DateTime.Today.Add(secilen.CheckoutTime);
                chkActive.Checked = secilen.IsActive;
            }
        }
    }
}
