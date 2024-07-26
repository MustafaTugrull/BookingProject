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
    public partial class Frm_OdaTip : Form
    {
        private readonly RoomTypeService _roomTypeService;
        public Frm_OdaTip()
        {
            InitializeComponent();
            var dbContext = new ApplicationDbContext();
            var _rRepo = new RoomTypeRepository(dbContext);
            _roomTypeService = new RoomTypeService(_rRepo);

        }

        private void Frm_OdaTip_Load(object sender, EventArgs e)
        {
            GetAllOdaType();
        }

        private void GetAllOdaType()
        {
            lstOdaTip.ValueMember = "Id";
            lstOdaTip.DisplayMember = "Name";
            lstOdaTip.DataSource = _roomTypeService.GetAll();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                RoomType newrType = new RoomType()
                {
                    Id = Guid.NewGuid(),
                    Name = txtAd.Text,
                    Description = txtAciklama.Text,
                    PricePerNight = nmrUcret.Value,
                    Capacity = (int)nmrKapasite.Value,
                    IsActive = true,
                    CreatedDate = DateTime.Now
                };

                _roomTypeService.Create(newrType);
                MessageBox.Show("Kayıt Başarılı");
                GetAllOdaType();
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
                secilen.Name= txtAd.Text;
                secilen.Description= txtAciklama.Text;
                secilen.PricePerNight= nmrUcret.Value;
                secilen.Capacity = (int)nmrKapasite.Value;

                _roomTypeService.Update(secilen);
                MessageBox.Show("Güncelleme Başarılı.");
                GetAllOdaType();
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
                if (lstOdaTip.SelectedIndex != -1)
                {
                    Guid id = (Guid)lstOdaTip.SelectedValue;
                    _roomTypeService.Delete(id);
                    GetAllOdaType();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        RoomType secilen;
        private void lstOdaTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOdaTip.SelectedIndex!=-1)
            {
                secilen = (RoomType)lstOdaTip.SelectedItem;
                txtAd.Text = secilen.Name;
                txtAciklama .Text = secilen.Description;
                nmrUcret.Value = secilen.PricePerNight;
                nmrKapasite .Value = secilen.Capacity;
            }
        }
    }
}
