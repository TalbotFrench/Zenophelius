using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zenophelius.ViewModels
{
    public class AnchorButtonVM
    {
        public ButtonType ButtonType { get; set; }
        public string Action { get; set; } // Used to set where the button will direct the user
        public string RouteId { get; set; } // Used if an ID is needed for the above Action
    }
    public enum ButtonType
    {
        BackToList,
        Create,
        Delete,
        Details,
        Edit,
        Save,
        Submit
    }
}