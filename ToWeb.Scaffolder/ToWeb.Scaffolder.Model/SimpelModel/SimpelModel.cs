
using System;
using ToWeb.Scaffolder.Essentials.Model;

namespace ToWeb.Scaffolder.Models.SimpelModel
{
    [Serializable()]
    public class SimpelModel : ScaffolderBaseModel
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public SimpelModel(){}

        public SimpelModel(string title)
        {
            Title = title;
            Date = DateTime.Now;
        }
    }
}
