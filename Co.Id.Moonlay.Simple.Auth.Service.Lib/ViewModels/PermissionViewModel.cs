﻿using Co.Id.Moonlay.Simple.Auth.Service.Lib.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Co.Id.Moonlay.Simple.Auth.Service.Lib.ViewModels
{
    public class PermissionViewModel
    {
        //public PermissionViewModel()
        //{

        //}

        //public PermissionViewModel(Permission permission)
        //{
        //    id = permission.Id;
        //}

        public int id { get; set; }
        public DateTime _createdDate { get; set; }
        public string _createdBy { get; set; }
        public string _createAgent { get; set; }
        public JobTitleViewModel jobTitle { get; set; }
        public int permission { get; set; }
        public int roleId { get; set; }
    }
}
