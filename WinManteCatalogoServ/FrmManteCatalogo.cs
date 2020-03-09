using AppBE;
using AppBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using UiUtilities;
using Utilities;

namespace WinManteCatalogoServ
{
    public partial class FrmManteCatalogo : UiUtilities.FrmManteBase
    {
        CatalogoServBE catSrvBE;

        public CatalogoServBE CatSrvBE
        {
            get { return catSrvBE; }
            set { catSrvBE = value; }
        }
        CatalogoServBL catSrvBL;

        public FrmManteCatalogo()
        {
            try
            {
                InitializeComponent();
                InitMyComponents();
            }
            catch (Exception)
            {

                throw;
            }

        }

        public FrmManteCatalogo(FormEstados pEstForm)
        {
            try
            {
                this.EstadoForm = pEstForm;
                InitializeComponent();
                InitMyComponents();
            }
            catch (Exception)
            {

                throw;
            }

        }



        private void InitMyComponents()
        {
            this.catSrvBE = new CatalogoServBE();
            this.catSrvBL = new CatalogoServBL();
            FillCombos();
            txtInd_AtmServV.Text = "E";
            txtNumCache.Text = "60";



        }

        protected override void FrmManteBase_Load(object sender, EventArgs e)
        {
            base.FrmManteBase_Load(sender, e);
            if (this.EstadoForm == FormEstados.ModModif ||
                this.EstadoForm == FormEstados.ModBorrar)
            {
                this.catSrvBL.GetServiceDataByPk(this.catSrvBE.CodServicioN, this.catSrvBE);
                BEtoUI();
            }
            else
            {
                this.catSrvBE = new CatalogoServBE();
            }


        }

        private void FillCombos()
        {
            try
            {
                CatalogosGenericosBL catGenBL = new CatalogosGenericosBL();
                DataSet ds;

                ds = catGenBL.GetTiposRetorno();

                CombosUtil.InitCombo(ds, cmbCodTipretornoN, "codigo", "descripcion");

                ds = catGenBL.GetTiposServicios();
                CombosUtil.InitCombo(ds, cmbCodTipservicioN, "codigo", "descripcion");


                ds = catGenBL.GetObjetoProp();
                CombosUtil.InitCombo(ds, cmbCodObjPropN, "codigo", "descripcion");

                ds = catGenBL.GetCodModulo();
                CombosUtil.InitCombo(ds, cmbCodModuloN, "codigo", "descripcion");

                ds = catGenBL.GetAccionServicio();
                CombosUtil.InitCombo(ds, cmbCodAccservN, "codigo", "descripcion");


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void UItoBE()
        {
            catSrvBE.CodServicioN = Convert.ToInt32(txtCodServicioN.Text);
            catSrvBE.CodTipretornoN = Convert.ToInt32(cmbCodTipretornoN.SelectedValue);
            catSrvBE.CodObjpropN = Convert.ToInt32(cmbCodObjPropN.SelectedValue);
            catSrvBE.CodTipservicioN = Convert.ToInt32(cmbCodTipservicioN.SelectedValue);
            catSrvBE.CodAccservN = Convert.ToInt32(cmbCodAccservN.SelectedValue);
            catSrvBE.NomServicio = txtNomServicio.Text;
            catSrvBE.IndAtomservV = txtInd_AtmServV.Text;
            catSrvBE.CodModuloN = Convert.ToInt32(cmbCodModuloN.SelectedValue);
            catSrvBE.DesServicio = txtDesServicio.Text;
            catSrvBE.NumCache = Convert.ToInt32(txtNumCache.Text);
            catSrvBE.DesInvocador = txtDesInvocador.Text;
            //catSrvBE.CodRegistroN = 0;
            //catSrvBE.CodEstadoN = 0;
            catSrvBE.IndLogueo = (chkIndLogeo.Checked ? 1 : 0);
            catSrvBE.IndPublico = (chkIndPublicoN.Checked ? 1 : 0);
            catSrvBE.DesEsquema = txtDesEsquema.Text;
        }

        private void BEtoUI()
        {
            txtCodServicioN.Text = Convert.ToString(catSrvBE.CodServicioN);
            cmbCodTipretornoN.SelectedValue = catSrvBE.CodTipretornoN;
            cmbCodObjPropN.SelectedValue = catSrvBE.CodObjpropN;
            cmbCodTipservicioN.SelectedValue = catSrvBE.CodTipservicioN;
            cmbCodAccservN.SelectedValue = catSrvBE.CodAccservN;
            txtNomServicio.Text = catSrvBE.NomServicio;
            txtInd_AtmServV.Text = "E";
            cmbCodModuloN.SelectedValue = catSrvBE.CodModuloN;
            txtDesServicio.Text = catSrvBE.DesServicio;
            txtNumCache.Text = Convert.ToString(catSrvBE.NumCache);
            txtDesInvocador.Text = catSrvBE.DesInvocador;
            // catSrvBE.CodRegistroN = 0;
            // catSrvBE.CodEstadoN = 0;
            chkIndLogeo.Checked = (this.catSrvBE.IndLogueo == 1);
            chkIndLogeo.Checked = (this.catSrvBE.IndLogueo == 1);
            chkIndPublicoN.Checked = (this.catSrvBE.IndPublico == 1);
            txtDesEsquema.Text = catSrvBE.DesEsquema;
        }

        protected override void InsertaReg()
        {
            try
            {
                decimal newCodServicioN = this.catSrvBL.NewCodServicio();
                txtCodServicioN.Text = Convert.ToString(newCodServicioN);
                UItoBE();
                this.catSrvBE.CodEstadoN = 2;  // activo
                this.catSrvBL.Insertar(this.catSrvBE);
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected override void ModifReg()
        {
            try
            {
                base.ModifReg();
                UItoBE();
                this.catSrvBL.Modificar(this.CatSrvBE);
            }
            catch (Exception)
            {
                
                throw;
            }
            


        }

        protected override void BorraReg()
        {
            try
            {
                if (MessageBox.Show ("¿Desea Eliminar el registro?", "Confirmacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.catSrvBL.Borrar(this.catSrvBE.CodServicioN);
                    MessageBox.Show("Registro Eliminado?");
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
