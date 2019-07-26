﻿
using HeBianGu.ExplorePlayer.Base.Model;
using HeBianGu.ExplorePlayer.General.SqliteDataBase;
using HeBianGu.ExplorePlayer.Respository.IService;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HeBianGu.ExplorePlayer.Respository.Serice
{
    public class AreaRespository : ServiceRepositoryBase<mbc_db_areatype>, IAreaRespository
    {
        public AreaRespository(DataContext dbcontext) : base(dbcontext)
        {

        } 
    }
}
