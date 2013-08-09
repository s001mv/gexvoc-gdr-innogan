using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace GEXVOC.Core.Generic
{
    public class SortableBindingList<T> : BindingList<T>
    {

        private List<T> _sortableList;

        public SortableBindingList(List<T> list): base(list)
        {
            _sortableList = list;
        }

 

        protected override bool SupportsSortingCore
        {
            get { return true; }
        }

 

        protected override void ApplySortCore(PropertyDescriptor property, ListSortDirection direction)
        {

            string sortExpression = property.Name;
            if (direction == ListSortDirection.Descending)            
                sortExpression = sortExpression + " DESC";

            DynamicComparer<T> comparer = new DynamicComparer<T>(sortExpression);
            _sortableList.Sort(comparer.Compare);
        }

 

        protected override void RemoveSortCore() {}

    }
}
