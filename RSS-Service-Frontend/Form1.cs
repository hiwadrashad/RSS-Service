using RSS_Service_Library.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RSS_Service_Library.Extension_Methods;
using RSS_Service_Library.ModelsNu;

namespace RSS_Service_Frontend
{
    public partial class Form1 : Form
    {
        IRepository Database = RSS_Service_Data_Base.MockingDatabase.MockingRepo.GetMockingRepo();
        public  Form1()
        {
            InitializeComponent();
            Thread.Sleep(5000);
            foreach(var a in Database.GetNuDataBase())
            {
                //await itemlist.Items.Add(item.Channel.Item[0].Guid.Text);
                //itemlist.Items.Add(item.Channel.Title);
                //itemlist.Items.Add(item.Channel.Item[0].PubDate);
                //itemlist.Items.Add(item.Channel.Item[0].Guid.Text);
                //itemlist.Items.Add(item.Channel.Link[0]);
            }
            //foreach (SyndicationItem item in feed.Items)
            //{
            //    RSS_Service_LIB.ModelsNu.NuRss Model = new RSS_Service_LIB.ModelsNu.NuRss();
            //    Model.Channel = new RSS_Service_LIB.ModelsNu.Channel();
            //    Model.Channel.Item = new List<RSS_Service_LIB.ModelsNu.Item>();
            //    Model.Channel.Item.Add(new RSS_Service_LIB.ModelsNu.Item());
            //    Model.Channel.Item[0].Guid = new RSS_Service_LIB.ModelsNu.Guid();

            //    Model.Channel.Item[0].Guid.Text = item.Id;

            //    Model.Channel.Title = item.Title.Text.ToString();

            //    Model.Channel.Item[0].PubDate = item.PublishDate.ToString();

            //    Model.Channel.Link = new System.Collections.Generic.List<string>();
            //    Model.Channel.Link.Add(item.Links[0].Uri.ToString());

            //    storage.Add(Model);

            //}
        }

    }
}
