﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Yamui.Framework.Forms;
using Yamui.Framework.Controls;

namespace Yamui.DemoApp
{
    public partial class Form2 : YamuiMainAppli
    {
        public Form2() {
            InitializeComponent();

            CloseAllBox = true;

            htmlLabel1.HasBorder = true;
            htmlLabel1.AutoSize = false;
            htmlLabel1.AutoSizeHeightOnly = false;
            htmlLabel1.Text = "fuckkkk<br>second ligiiiiiiiiiiiiiiiiiiiiine";


            //htmlPanel1.Text = "<div class=\"release-body commit open float-left\">\r\n    <div class=\"release-header\">\r\n        <a href=\"/jcaillon/3P/releases/edit/v1.8.1\" class=\"release-edit btn btn-sm float-right\">Edit</a>\r\n\r\n      <h1 class=\"release-title text-normal\">\r\n        <a href=\"/jcaillon/3P/releases/tag/v1.8.1\">v1.8.1</a>\r\n      </h1>\r\n      <p class=\"f5 text-gray mt-1 mb-4\">\r\n        <img class=\"avatar\" src=\"https://avatars0.githubusercontent.com/u/11553075?s=40&amp;v=4\" width=\"20\" height=\"20\" alt=\"@jcaillon\">\r\n        <a href=\"/jcaillon\" class=\"text-bold text-gray\">jcaillon</a>\r\n        released this\r\n          <relative-time datetime=\"2018-03-04T20:55:10Z\" title=\"Mar 4, 2018, 9:55 PM GMT+1\">on Mar 4</relative-time>\r\n\r\n      </p>\r\n    </div>\r\n\r\n      <div class=\"my-4\">\r\n        <h2 class=\"f3\">Assets</h2>\r\n        <ul class=\"mt-2\">\r\n            <li class=\"d-block py-2\">\r\n              <a href=\"/jcaillon/3P/releases/download/v1.8.1/3P.zip\" rel=\"nofollow\">\r\n                <small class=\"text-gray float-right\">1.32 MB</small>\r\n                <svg class=\"octicon octicon-package text-gray d-inline-block\" viewBox=\"0 0 16 16\" version=\"1.1\" width=\"16\" height=\"16\" aria-hidden=\"true\"><path fill-rule=\"evenodd\" d=\"M1 4.27v7.47c0 .45.3.84.75.97l6.5 1.73c.16.05.34.05.5 0l6.5-1.73c.45-.13.75-.52.75-.97V4.27c0-.45-.3-.84-.75-.97l-6.5-1.74a1.4 1.4 0 0 0-.5 0L1.75 3.3c-.45.13-.75.52-.75.97zm7 9.09l-6-1.59V5l6 1.61v6.75zM2 4l2.5-.67L11 5.06l-2.5.67L2 4zm13 7.77l-6 1.59V6.61l2-.55V8.5l2-.53V5.53L15 5v6.77zm-2-7.24L6.5 2.8l2-.53L15 4l-2 .53z\"></path></svg>\r\n                <strong class=\"pl-1\">3P.zip</strong>\r\n              </a>\r\n            </li>\r\n            <li class=\"d-block py-2\">\r\n              <a href=\"/jcaillon/3P/releases/download/v1.8.1/3P_x64.zip\" rel=\"nofollow\">\r\n                <small class=\"text-gray float-right\">1.32 MB</small>\r\n                <svg class=\"octicon octicon-package text-gray d-inline-block\" viewBox=\"0 0 16 16\" version=\"1.1\" width=\"16\" height=\"16\" aria-hidden=\"true\"><path fill-rule=\"evenodd\" d=\"M1 4.27v7.47c0 .45.3.84.75.97l6.5 1.73c.16.05.34.05.5 0l6.5-1.73c.45-.13.75-.52.75-.97V4.27c0-.45-.3-.84-.75-.97l-6.5-1.74a1.4 1.4 0 0 0-.5 0L1.75 3.3c-.45.13-.75.52-.75.97zm7 9.09l-6-1.59V5l6 1.61v6.75zM2 4l2.5-.67L11 5.06l-2.5.67L2 4zm13 7.77l-6 1.59V6.61l2-.55V8.5l2-.53V5.53L15 5v6.77zm-2-7.24L6.5 2.8l2-.53L15 4l-2 .53z\"></path></svg>\r\n                <strong class=\"pl-1\">3P_x64.zip</strong>\r\n              </a>\r\n            </li>\r\n\r\n\r\n            <li class=\"d-block py-2\">\r\n              <a href=\"/jcaillon/3P/archive/v1.8.1.zip\" rel=\"nofollow\">\r\n                <svg class=\"octicon octicon-file-zip text-gray d-inline-block ml-1\" viewBox=\"0 0 12 16\" version=\"1.1\" width=\"12\" height=\"16\" aria-hidden=\"true\"><path fill-rule=\"evenodd\" d=\"M8.5 1H1a1 1 0 0 0-1 1v12a1 1 0 0 0 1 1h10a1 1 0 0 0 1-1V4.5L8.5 1zM11 14H1V2h3v1h1V2h3l3 3v9zM5 4V3h1v1H5zM4 4h1v1H4V4zm1 2V5h1v1H5zM4 6h1v1H4V6zm1 2V7h1v1H5zM4 9.28A2 2 0 0 0 3 11v1h4v-1a2 2 0 0 0-2-2V8H4v1.28zM6 10v1H4v-1h2z\"></path></svg>\r\n                <strong class=\"pl-1\">Source code</strong> (zip)\r\n              </a>\r\n            </li>\r\n            <li class=\"d-block py-2\">\r\n              <a href=\"/jcaillon/3P/archive/v1.8.1.tar.gz\" rel=\"nofollow\">\r\n                <svg class=\"octicon octicon-file-zip text-gray d-inline-block ml-1\" viewBox=\"0 0 12 16\" version=\"1.1\" width=\"12\" height=\"16\" aria-hidden=\"true\"><path fill-rule=\"evenodd\" d=\"M8.5 1H1a1 1 0 0 0-1 1v12a1 1 0 0 0 1 1h10a1 1 0 0 0 1-1V4.5L8.5 1zM11 14H1V2h3v1h1V2h3l3 3v9zM5 4V3h1v1H5zM4 4h1v1H4V4zm1 2V5h1v1H5zM4 6h1v1H4V6zm1 2V7h1v1H5zM4 9.28A2 2 0 0 0 3 11v1h4v-1a2 2 0 0 0-2-2V8H4v1.28zM6 10v1H4v-1h2z\"></path></svg>\r\n                <strong class=\"pl-1\">Source code</strong> (tar.gz)\r\n              </a>\r\n            </li>\r\n        </ul>\r\n      </div>\r\n\r\n      <div class=\"markdown-body\">\r\n        <p>Hello everyone,</p>\r\n<p>If you are reading this update message from 3P, thank you for understanding my need to update to .net 4.6.2! Read more about this below...</p>\r\n<p>This release is mainly to fix the updater and to target .net 4.6.2, new features are coming in the next release, stay tuned!</p>\r\n<h3>Important notes :###</h3>\r\n<p>Since February 22 the 3P automatic updater is not working and displays a message saying it failed to query the github API.</p>\r\n<p>The 3P updater is using the <a href=\"https://developer.github.com/v3/\">github API</a> to check for new releases and download the .zip file. Last Thursday, GitHub turned off some weak crypto standards; including TLSv1.1. <a href=\"https://githubengineering.com/crypto-removal-notice/\" rel=\"nofollow\">You can read about this here.</a></p>\r\n<p>How is it related you ask? I\'ve build 3P around the .NET framework v4.0 which only supports TLSv1.1. This is the default security protocol and also the latest protocol supported by this version. This means I had to upgrade the project to a newer version of the .net framework : <a href=\"https://www.microsoft.com/en-us/download/details.aspx?id=53344\" rel=\"nofollow\">.NET 4.6.2</a>. That also means that 3P will not be able to run on windows versions inferior to windows 7. Learn more in <a href=\"https://github.com/jcaillon/3P/issues/217\">issue 217</a> and in <a href=\"https://github.com/jcaillon/3P/issues/214\">issue 214</a>.</p>\r\n<h3>Improvements :###</h3>\r\n<ul>\r\n<li>Allow drag and drop on textboxes! <em>finally</em></li>\r\n<li><a class=\"issue-link js-issue-link\" data-error-text=\"Failed to load issue title\" data-id=\"300054054\" data-permission-text=\"Issue title is private\" data-url=\"https://github.com/jcaillon/3P/issues/215\" href=\"https://github.com/jcaillon/3P/issues/215\">#215</a> : Remove multiple database configuration per environment</li>\r\n</ul>\r\n<h3>Fixed issues :###</h3>\r\n<ul>\r\n<li><a class=\"issue-link js-issue-link\" data-error-text=\"Failed to load issue title\" data-id=\"300034648\" data-permission-text=\"Issue title is private\" data-url=\"https://github.com/jcaillon/3P/issues/214\" href=\"https://github.com/jcaillon/3P/issues/214\">#214</a> : Updater error : Couldn\'t query GITHUB API</li>\r\n</ul>\r\n<p>Thank you for reading,</p>\r\n<p>Enjoy</p>\r\n      </div>\r\n\r\n  </div>";
        }

        private void yamuiButton1_ButtonPressed(object sender, EventArgs e)
        {
            var toastNotification = new YamuiNotification("title", "<img src='high_importance' />This is a notification test", 120);
            toastNotification.Show();
            var toastNotification2 = new YamuiNotification("title", "<img src='poison' />Can i display a link? <br><a href='plswork?'>yop</a>", 0);
            toastNotification2.Show();
        }
    }
}
