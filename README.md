# How to load user control to titlebar of RibbonForm

This repository contains a sample that demonstrates how to load a user control into the title bar of a Syncfusion RibbonForm. The sample creates a `RibbonControlAdv`, configures it with Home, Send, and Folder tabs, and attaches a `BackStageView` with multiple backstage items such as Open, Save Attachments, Office Accounts, Print, and Close.

In this example, an `SfButton` is created programmatically, styled with custom colors and text, and assigned to the title bar by setting the `HeaderItem` property of the RibbonForm. The button is displayed as a **Sign-In** action in the right side of the title bar, showing how custom controls can be integrated into the RibbonForm header area.

This approach is useful for WinForms applications that need quick access actions such as sign-in, profile, or settings directly in the title bar while preserving the standard ribbon and backstage layout.

Documentation: https://help.syncfusion.com/windowsforms/ribbon/ribbon-form