﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
  public class TruckVM : NotificationBase
  {
    public string ID { get; set; }
    public string Name { get; set; }
    public string Style { get; set; }
  }
}
