using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeaderItem
{
    public partial class Form1 : RibbonForm
    {
        private Syncfusion.Windows.Forms.Tools.RibbonControlAdv ribbonControlAdv1;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem homeTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem sendTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripTabItem folderTabItem;
        private Syncfusion.Windows.Forms.Tools.ToolStripEx newToolStripEx;
        private Syncfusion.Windows.Forms.BackStageView backStageView1;
        private Syncfusion.Windows.Forms.BackStage backStage1;
        private Syncfusion.Windows.Forms.BackStageTab openExportBackStageTab;
        private Syncfusion.Windows.Forms.BackStageTab saveAttachmentsBackStageTab;
        private Syncfusion.Windows.Forms.BackStageTab openBackStageTab;
        private Syncfusion.Windows.Forms.BackStageTab officeAccountsBackStageTab;
        private Syncfusion.Windows.Forms.BackStageSeparator backStageSeparator;
        private Syncfusion.Windows.Forms.BackStageTab printBackStageTab;
        private Syncfusion.Windows.Forms.BackStageButton closeBackStageButton;
        private Syncfusion.WinForms.Controls.SfButton button;
        public Form1()
        {
            InitializeComponent();
            this.ribbonControlAdv1 = new Syncfusion.Windows.Forms.Tools.RibbonControlAdv();
            this.homeTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.sendTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.folderTabItem = new Syncfusion.Windows.Forms.Tools.ToolStripTabItem();
            this.newToolStripEx = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.backStageView1 = new Syncfusion.Windows.Forms.BackStageView(this.components);
            this.backStage1 = new Syncfusion.Windows.Forms.BackStage();
            this.openExportBackStageTab = new Syncfusion.Windows.Forms.BackStageTab();
            this.saveAttachmentsBackStageTab = new Syncfusion.Windows.Forms.BackStageTab();
            this.openBackStageTab = new Syncfusion.Windows.Forms.BackStageTab();
            this.officeAccountsBackStageTab = new Syncfusion.Windows.Forms.BackStageTab();
            this.backStageSeparator = new Syncfusion.Windows.Forms.BackStageSeparator();
            this.printBackStageTab = new Syncfusion.Windows.Forms.BackStageTab();
            this.closeBackStageButton = new Syncfusion.Windows.Forms.BackStageButton();

            this.ribbonControlAdv1.BackStageView = this.backStageView1;
            this.ribbonControlAdv1.MenuButtonText = "File";
            this.ribbonControlAdv1.Size = new System.Drawing.Size(1036, 160);
            this.ribbonControlAdv1.RibbonStyle = RibbonStyle.Office2016;
            this.Controls.Add(ribbonControlAdv1);

            this.homeTabItem.Text = "Home";
            this.sendTabItem.Text = "Send";
            this.folderTabItem.Text = "Folder";

            this.ribbonControlAdv1.Header.AddMainItem(this.homeTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(this.sendTabItem);
            this.ribbonControlAdv1.Header.AddMainItem(this.folderTabItem);

            this.newToolStripEx.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.homeTabItem.Panel.Controls.Add(newToolStripEx);

            this.button = new SfButton();
            this.button.ForeColor = Color.White;
            this.button.Font = Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.button.Size = new System.Drawing.Size(75, 50);
            this.button.Text = "Sign-In";
            this.button.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.button.Style.HoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(141)))), ((int)(((byte)(212)))));
            this.button.Style.FocusedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button.Style.PressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(87)))), ((int)(((byte)(154)))));
            this.button.Style.PressedForeColor = Color.White;
            this.button.Style.HoverForeColor = Color.White;
            this.button.Style.FocusedForeColor = Color.White;
            this.HeaderItem = button;

            this.backStageView1.BackStage = this.backStage1;
            this.backStageView1.HostControl = null;
            this.backStageView1.HostForm = this;

            this.openExportBackStageTab.Text = "Open/Export";
            this.saveAttachmentsBackStageTab.Text = "Save Attachments";
            this.openBackStageTab.Text = "Open";
            this.officeAccountsBackStageTab.Text = "Office Accounts";
            this.printBackStageTab.Text = "Print";
            this.closeBackStageButton.Text = "Close";

            this.backStage1.Controls.Add(openExportBackStageTab);
            this.backStage1.Controls.Add(saveAttachmentsBackStageTab);
            this.backStage1.Controls.Add(openBackStageTab);
            this.backStage1.Controls.Add(officeAccountsBackStageTab);
            this.backStage1.Controls.Add(backStageSeparator);
            this.backStage1.Controls.Add(printBackStageTab);
            this.backStage1.Controls.Add(closeBackStageButton);
        }
    }
}
