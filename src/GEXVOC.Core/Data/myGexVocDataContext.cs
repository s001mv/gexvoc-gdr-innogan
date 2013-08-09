using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using GEXVOC.Core.Logic;
using System.Data.Linq.Mapping;



namespace GEXVOC.Core.Data
{
    

    partial class myGexVocDataContext : GEXVOCDataContext
    {
        partial void OnCreated();

        private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
       

        public override void SubmitChanges(System.Data.Linq.ConflictMode failureMode)
        {
            ChangeSet cambios = this.GetChangeSet();
            

            base.SubmitChanges(failureMode);
        }

        public myGexVocDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
       

    }
}
