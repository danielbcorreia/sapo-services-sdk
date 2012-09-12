﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Videos.SapoServices;
using Videos.VideosServiceReference;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace Videos
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private async void BtPickVideoClick(object sender, RoutedEventArgs e)
        {
            FileOpenPicker openPicker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.VideosLibrary
            };
            openPicker.FileTypeFilter.Add(".avi");
            openPicker.FileTypeFilter.Add(".mp4");

            StorageFile file = await openPicker.PickSingleFileAsync();
            if (file != null)
            {
                var client = new VideosServiceClient(this.tb_authUsername.Text,
                    this.tb_authPassword.Text, this.tb_authAccessKey.Text);
                Video video = new Video {Title = file.DisplayName, Tags = file.DisplayName, Synopse = file.DisplayName};
                this.tblock_PostVideoResult.Text = await client.CreateVideoAsync(file, video);
            }
            else
            {
                this.tblock_PostVideoResult.Text = "Error reading file";
            }

        }

        private void BtDeleteVideoClick(object sender, RoutedEventArgs e)
        {
            var client = new VideosServiceClient(this.tb_authUsername.Text,
                    this.tb_authPassword.Text, this.tb_authAccessKey.Text);

            client.DeleteVideoAsync(this.tb_VideoRandnameForDeleteVideo.Text);
        }

        private void BtEditVideoClick(object sender, RoutedEventArgs e)
        {
            var client = new VideosServiceClient(this.tb_authUsername.Text,
                    this.tb_authPassword.Text, this.tb_authAccessKey.Text);


            //Title é obrigatório!!!!!!!!!

            VideoSubmition v = new VideoSubmition
                                   {
                                       Randname = this.tb_VideoRandnameForEditVideo.Text,
                                       Synopse = this.tb_VideoSynopseForEditVideo.Text,
                                       Title = "Novo nome"

                                   };

            client.EditVideoAsync(v);
        }

        private async void BtGetVideoClick(object sender, RoutedEventArgs e)
        {
            var client = new VideosServiceClient(this.tb_authUsername.Text,
                    this.tb_authPassword.Text, this.tb_authAccessKey.Text);

            Video v = await client.GetVideoAsync(null, null, this.tb_VideoRandnameForGetVideo.Text, null, 0);

        }

        private async void BtGetUserClick(object sender, RoutedEventArgs e)
        {
            var client = new VideosServiceClient(this.tb_authUsername.Text,
                    this.tb_authPassword.Text, this.tb_authAccessKey.Text);

            User u = await client.GetUserAsync(this.tb_UserNameForGetUser.Text);
        }

        private async void BtGetUserVideosClick(object sender, RoutedEventArgs e)
        {
            var client = new VideosServiceClient(this.tb_authUsername.Text,
                    this.tb_authPassword.Text, this.tb_authAccessKey.Text);
            Video[] videos = await client.GetUserVideos(null, null, null, 50, 1);
        }

        private async void BtQueryVideosClick(object sender, RoutedEventArgs e)
        {
            var client = new VideosServiceClient(this.tb_authUsername.Text,
                    this.tb_authPassword.Text, this.tb_authAccessKey.Text);

            Video[] videos = await client.QueryAsync(null, this.tb_TagsForQueryVideos.Text, 0, 30, null, 5, null, 5);
        }
    }
}
