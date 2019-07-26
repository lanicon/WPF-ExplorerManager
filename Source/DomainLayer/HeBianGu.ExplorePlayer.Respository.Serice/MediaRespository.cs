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
    public class MediaRespository : ServiceRepositoryBase<mbc_db_mediatype>, IMediaRespository
    {
        public MediaRespository(DataContext dbcontext) : base(dbcontext)
        {

        } 
    }
}
