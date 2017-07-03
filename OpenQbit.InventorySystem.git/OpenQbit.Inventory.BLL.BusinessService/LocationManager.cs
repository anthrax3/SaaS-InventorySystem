﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQbit.Inventory.Common.Models;
using OpenQbit.Inventory.Common.Utils.Logs;
using OpenQbit.Inventory.DAL.DataAccess.Contr;
using OpenQbit.Inventory.BLL.BusinessService.Contr;
using Microsoft.Practices.Unity;

namespace OpenQbit.Inventory.BLL.BusinessService
{
    public class LocationManager : ILocationManager
    {
        private IRepository _repository;

        private ILogger _log;

        [InjectionConstructor]
        public LocationManager(IRepository repository, ILogger log)
        {
            this._repository = repository;
            this._log = log;
        }


        public bool RecordLocation(Location location)
        {
            _log.LogError("");
            return _repository.Create<Location>(location);
        }
    }
}
