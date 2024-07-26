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
        public Frm_Misafir()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var _gRepo = new GuestRepository(dbContext);
            _guestService = new GuestService(_gRepo);

        }

        private void Frm_Misafir_Load(object sender, EventArgs e)
        {
            GetAllGuest();
        }

        private void GetAllGuest()
        {
            lstMisafir.ValueMember = "Id";
            lstMisafir.DisplayMember = "FullName";
            lstMisafir.DataSource = _guestService.GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                Guest newGuest = new Guest()
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

                _guestService.Create(newGuest);
                MessageBox.Show("Kayıt Başarılı");
                GetAllGuest();
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
                secilen.FirstName = txtAd.Text;
                secilen.LastName = txtSoyad.Text;
                secilen.TCKN = txtTCKN.Text;
                secilen.DateOfBirth = dtpDateOfBirth.Value;
                secilen.Address = txtAdres.Text;
                secilen.Phone = txtTel.Text;
                secilen.Email = txtMail.Text;

                _guestService.Update(secilen);
                MessageBox.Show("Güncelleme Başarılı.");
                GetAllGuest();
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
                if (lstMisafir.SelectedIndex != -1)
                {
                    Guid id = (Guid)lstMisafir.SelectedValue;
                    _guestService.Delete(id);
                    GetAllGuest();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}
