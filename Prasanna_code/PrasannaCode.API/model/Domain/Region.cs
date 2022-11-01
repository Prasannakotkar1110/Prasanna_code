﻿namespace PrasannaCode.API.model.Domain
{
    public class Region
    {
        public Guid id { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public double Area { get; set; }

        public double lat { get; set; }

        public double Long { get; set; }

        public long Population { get; set; }

        //Nevigation Property

        public IEnumerable<Walk> Walks { get; set; }            
        



    }
}
