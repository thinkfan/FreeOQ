using System;
using System.ComponentModel;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FreeQuant.FinChart
{
  public class ToolBar : UserControl
  {
		private Chart chart; 
    private ToolTip sf4SjX1ToR;
    private ImageList N8BSouAZN1;
    private ToolBarButton GHZSaNnkGg;
    private ToolBarButton tM9SpQ48d1;
    private ToolBarButton d90SW54h6P;
    private System.Windows.Forms.ToolBar uPSSFuKEDk;
    private ToolBarButton kbZSI7yHWF;
    private ToolBarButton SHBSzi5RWV;
    private ToolBarButton sav0tem4ql;
    private ToolBarButton rTk0wOhRro;
    private ToolBarButton L4H0cGUhOc;
    private ToolBarButton gnW0JYdeuq;
    private ToolBarButton W840yr4JgF;
    private ToolBarButton tk80SKptT6;
    private ToolBarButton SDT00J8DRD;
    private ToolBarButton Bla0rORiyV;
    private ToolBarButton Jxd0K4UyYR;
    private ToolBarButton SYG0iI8HBl;
    private ToolBarButton HOr0XJ5GIq;
    private ToolBarButton GW90DgPn0G;
		private IContainer container; 

    public Chart Chart
    {
       get
      {
        return this.chart;
      }
       set
      {
        this.PUISLLKlgW();
        this.chart = value;
        this.drPSqOMJnJ();
        this.gLtSH1DvrV();
        this.CmxSgv1abt();
        this.roGSVnjCu8();
        this.d3gS2B1EsO();
        this.csRSYcSfK9();
      }
    }

   
		public ToolBar(Chart chart = null) : base()
    {
      this.Chart = chart;
    }

    
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.container != null)
        this.container.Dispose();
      base.Dispose(disposing);
    }

    
    private void tb4SlKoQaK()
    {
      this.container = (IContainer) new Container();
      ResourceManager resourceManager = new ResourceManager(typeof (ToolBar));
      this.uPSSFuKEDk = new System.Windows.Forms.ToolBar();
      this.kbZSI7yHWF = new ToolBarButton();
      this.SHBSzi5RWV = new ToolBarButton();
      this.GHZSaNnkGg = new ToolBarButton();
      this.sav0tem4ql = new ToolBarButton();
      this.rTk0wOhRro = new ToolBarButton();
      this.tM9SpQ48d1 = new ToolBarButton();
      this.L4H0cGUhOc = new ToolBarButton();
      this.gnW0JYdeuq = new ToolBarButton();
      this.d90SW54h6P = new ToolBarButton();
      this.Jxd0K4UyYR = new ToolBarButton();
      this.SYG0iI8HBl = new ToolBarButton();
      this.HOr0XJ5GIq = new ToolBarButton();
      this.Bla0rORiyV = new ToolBarButton();
      this.W840yr4JgF = new ToolBarButton();
      this.tk80SKptT6 = new ToolBarButton();
      this.SDT00J8DRD = new ToolBarButton();
      this.GW90DgPn0G = new ToolBarButton();
      this.N8BSouAZN1 = new ImageList(this.container);
      this.sf4SjX1ToR = new ToolTip(this.container);
      this.SuspendLayout();
      this.uPSSFuKEDk.Appearance = ToolBarAppearance.Flat;
      this.uPSSFuKEDk.Buttons.AddRange(new ToolBarButton[17]
      {
        this.kbZSI7yHWF,
        this.SHBSzi5RWV,
        this.GHZSaNnkGg,
        this.sav0tem4ql,
        this.rTk0wOhRro,
        this.tM9SpQ48d1,
        this.L4H0cGUhOc,
        this.gnW0JYdeuq,
        this.d90SW54h6P,
        this.Jxd0K4UyYR,
        this.SYG0iI8HBl,
        this.HOr0XJ5GIq,
        this.Bla0rORiyV,
        this.W840yr4JgF,
        this.tk80SKptT6,
        this.SDT00J8DRD,
        this.GW90DgPn0G
      });
      this.uPSSFuKEDk.Dock = DockStyle.Fill;
      this.uPSSFuKEDk.DropDownArrows = true;
      this.uPSSFuKEDk.ImageList = this.N8BSouAZN1;
      this.uPSSFuKEDk.Location = new Point(0, 0);
			this.uPSSFuKEDk.Name = "dfdfs";
      this.uPSSFuKEDk.ShowToolTips = true;
      this.uPSSFuKEDk.Size = new Size(408, 28);
      this.uPSSFuKEDk.TabIndex = 0;
      this.uPSSFuKEDk.ButtonClick += new ToolBarButtonClickEventHandler(this.AiQSsBlXRC);
      this.kbZSI7yHWF.ImageIndex = 7;
			this.kbZSI7yHWF.ToolTipText = "dfdfs";
      this.SHBSzi5RWV.ImageIndex = 8;
			this.SHBSzi5RWV.ToolTipText = "dfdfs";
      this.GHZSaNnkGg.Style = ToolBarButtonStyle.Separator;
      this.sav0tem4ql.ImageIndex = 5;
			this.sav0tem4ql.ToolTipText = "dfdfs";
      this.rTk0wOhRro.ImageIndex = 6;
			this.rTk0wOhRro.ToolTipText = "dfdfs";
      this.tM9SpQ48d1.Style = ToolBarButtonStyle.Separator;
      this.L4H0cGUhOc.ImageIndex = 9;
			this.L4H0cGUhOc.ToolTipText = "dfdfs";
      this.gnW0JYdeuq.ImageIndex = 10;
			this.gnW0JYdeuq.ToolTipText = "dfdfs";
      this.d90SW54h6P.Style = ToolBarButtonStyle.Separator;
      this.Jxd0K4UyYR.ImageIndex = 17;
			this.Jxd0K4UyYR.ToolTipText = "dfdfs";
      this.Jxd0K4UyYR.Visible = false;
      this.SYG0iI8HBl.ImageIndex = 19;
			this.SYG0iI8HBl.ToolTipText = "dfdfs";
      this.HOr0XJ5GIq.ImageIndex = 18;
			this.HOr0XJ5GIq.ToolTipText = "dfdfs";
      this.Bla0rORiyV.Style = ToolBarButtonStyle.Separator;
      this.W840yr4JgF.ImageIndex = 11;
			this.W840yr4JgF.ToolTipText = "dfdfs";
      this.tk80SKptT6.ImageIndex = 12;
			this.tk80SKptT6.ToolTipText = "dfdfs";
      this.SDT00J8DRD.ImageIndex = 13;
			this.SDT00J8DRD.ToolTipText = "dfdfs";
      this.GW90DgPn0G.ImageIndex = 20;
			this.GW90DgPn0G.ToolTipText = "dfdfs";
      this.N8BSouAZN1.ImageSize = new Size(16, 16);
			this.N8BSouAZN1.ImageStream = (ImageListStreamer) resourceManager.GetObject("dfssdf");
      this.N8BSouAZN1.TransparentColor = Color.Transparent;
      this.Controls.Add((Control) this.uPSSFuKEDk);
			this.Name = "dfdfs";
      this.Size = new Size(408, 32);
      this.ResumeLayout(false);
    }

    
    private void VTHSvlWY7P()
    {
      this.chart.BarSeriesStyle = BSStyle.Candle;
    }

    
    private void fqTSdJFT0I()
    {
      this.chart.BarSeriesStyle = BSStyle.Bar;
    }

    
    private void C9MSu2Qyh1()
    {
      this.chart.BarSeriesStyle = BSStyle.Line;
    }

    
    private void OrDSxvD1vo()
    {
    }

    
    private void fgSSACIZ2R()
    {
    }

    
    private void U74S52iXhy()
    {
    }

    
    private void toySZxwXk7()
    {
      this.chart.ScaleStyle = PadScaleStyle.Arith;
    }

    
    private void DF4S4Bvlpe()
    {
      this.chart.ScaleStyle = PadScaleStyle.Log;
    }

    
    private void ogbSfOH4BE()
    {
			this.chart.ActionType = ChartActionType.Cross;
    }

    
    private void Jx5SGKnSDm()
    {
			this.chart.ActionType = ChartActionType.None;
    }

    
    private void ruCSkCeEMT()
    {
      this.chart.ZoomIn();
    }

    
    private void JcbSM8Pqgr()
    {
      this.chart.ZoomOut();
    }

    
    private void dVYSQC1Tub()
    {
      this.chart.UpdateStyle = ChartUpdateStyle.WholeRange;
    }

    
    private void IRdS60EPof()
    {
      this.chart.UpdateStyle = ChartUpdateStyle.Trailing;
    }

    
    private void G8SS93JwmO()
    {
      this.chart.UpdateStyle = ChartUpdateStyle.Fixed;
    }

    
    private void ocMSO3R2u1()
    {
      this.chart.BarSeriesStyle = BSStyle.PointAndFigure;
      this.chart.DrawItems = false;
    }

    
    private void AiQSsBlXRC([In] object obj0, [In] ToolBarButtonClickEventArgs obj1)
    {
      if (obj1.Button == this.sav0tem4ql)
        this.ruCSkCeEMT();
      if (obj1.Button == this.rTk0wOhRro)
        this.JcbSM8Pqgr();
      if (obj1.Button == this.SHBSzi5RWV)
        this.ogbSfOH4BE();
      if (obj1.Button == this.kbZSI7yHWF)
        this.Jx5SGKnSDm();
      if (obj1.Button == this.L4H0cGUhOc)
        this.toySZxwXk7();
      if (obj1.Button == this.gnW0JYdeuq)
        this.DF4S4Bvlpe();
      if (obj1.Button == this.W840yr4JgF)
        this.VTHSvlWY7P();
      if (obj1.Button == this.tk80SKptT6)
        this.fqTSdJFT0I();
      if (obj1.Button == this.SDT00J8DRD)
        this.C9MSu2Qyh1();
      if (obj1.Button == this.Jxd0K4UyYR)
        this.dVYSQC1Tub();
      if (obj1.Button == this.SYG0iI8HBl)
        this.IRdS60EPof();
      if (obj1.Button == this.HOr0XJ5GIq)
        this.G8SS93JwmO();
      if (obj1.Button != this.GW90DgPn0G)
        return;
      this.ocMSO3R2u1();
    }

    
    private void PUISLLKlgW()
    {
      if (this.chart == null)
        return;
      this.chart.ActionTypeChanged -= new EventHandler(this.lQxSNSiaOm);
      this.chart.UpdateStyleChanged -= new EventHandler(this.GhiSCyiVRF);
      this.chart.VolumeVisibleChanged -= new EventHandler(this.GRbSm8MtY1);
      this.chart.BarSeriesStyleChanged -= new EventHandler(this.KSTS3uqLm4);
      this.chart.ScaleStyleChanged -= new EventHandler(this.hUMS8DFqNU);
    }

    
    private void drPSqOMJnJ()
    {
      if (this.chart == null)
        return;
      this.chart.ActionTypeChanged += new EventHandler(this.lQxSNSiaOm);
      this.chart.UpdateStyleChanged += new EventHandler(this.GhiSCyiVRF);
      this.chart.VolumeVisibleChanged += new EventHandler(this.GRbSm8MtY1);
      this.chart.BarSeriesStyleChanged += new EventHandler(this.KSTS3uqLm4);
      this.chart.ScaleStyleChanged += new EventHandler(this.hUMS8DFqNU);
    }

    
    private void roGSVnjCu8()
    {
      if (this.chart.UpdateStyle == ChartUpdateStyle.Fixed)
      {
        this.HOr0XJ5GIq.Pushed = true;
        this.SYG0iI8HBl.Pushed = false;
        this.Jxd0K4UyYR.Pushed = false;
      }
      if (this.chart.UpdateStyle == ChartUpdateStyle.Trailing)
      {
        this.HOr0XJ5GIq.Pushed = false;
        this.SYG0iI8HBl.Pushed = true;
        this.Jxd0K4UyYR.Pushed = false;
      }
      if (this.chart.UpdateStyle != ChartUpdateStyle.WholeRange)
        return;
      this.HOr0XJ5GIq.Pushed = false;
      this.SYG0iI8HBl.Pushed = false;
      this.Jxd0K4UyYR.Pushed = true;
    }

    
    private void d3gS2B1EsO()
    {
    }

    
    private void CmxSgv1abt()
    {
      if (this.chart.BarSeriesStyle == BSStyle.Bar)
      {
        this.tk80SKptT6.Pushed = true;
        this.W840yr4JgF.Pushed = false;
        this.SDT00J8DRD.Pushed = false;
        this.GW90DgPn0G.Pushed = false;
      }
      if (this.chart.BarSeriesStyle == BSStyle.Candle)
      {
        this.tk80SKptT6.Pushed = false;
        this.W840yr4JgF.Pushed = true;
        this.SDT00J8DRD.Pushed = false;
        this.GW90DgPn0G.Pushed = false;
      }
      if (this.chart.BarSeriesStyle == BSStyle.Line)
      {
        this.tk80SKptT6.Pushed = false;
        this.W840yr4JgF.Pushed = false;
        this.SDT00J8DRD.Pushed = true;
        this.GW90DgPn0G.Pushed = false;
      }
      if (this.chart.BarSeriesStyle != BSStyle.PointAndFigure)
        return;
      this.tk80SKptT6.Pushed = false;
      this.W840yr4JgF.Pushed = false;
      this.SDT00J8DRD.Pushed = false;
      this.GW90DgPn0G.Pushed = true;
    }

    
    private void gLtSH1DvrV()
    {
			if (this.chart.ActionType == ChartActionType.Cross)
      {
        this.SHBSzi5RWV.Pushed = true;
        this.kbZSI7yHWF.Pushed = false;
      }
      if (this.chart.ActionType != ChartActionType.None)
        return;
      this.SHBSzi5RWV.Pushed = false;
      this.kbZSI7yHWF.Pushed = true;
    }

    
    private void csRSYcSfK9()
    {
      if (this.chart.ScaleStyle == PadScaleStyle.Arith)
      {
        this.L4H0cGUhOc.Pushed = true;
        this.gnW0JYdeuq.Pushed = false;
      }
      if (this.chart.ScaleStyle != PadScaleStyle.Log)
        return;
      this.L4H0cGUhOc.Pushed = false;
      this.gnW0JYdeuq.Pushed = true;
    }

    
    private void GhiSCyiVRF([In] object obj0, [In] EventArgs obj1)
    {
      this.roGSVnjCu8();
    }

    
    private void GRbSm8MtY1([In] object obj0, [In] EventArgs obj1)
    {
      this.d3gS2B1EsO();
    }

    
    private void KSTS3uqLm4([In] object obj0, [In] EventArgs obj1)
    {
      this.CmxSgv1abt();
    }

    
    private void lQxSNSiaOm([In] object obj0, [In] EventArgs obj1)
    {
      this.gLtSH1DvrV();
    }

    
    private void hUMS8DFqNU([In] object obj0, [In] EventArgs obj1)
    {
      this.csRSYcSfK9();
    }
  }
}
