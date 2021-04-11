using System;
using System.Collections.Generic;

public class PagnationHelper<T>
{
  private List<T> _Collection { get; set; }

        private int _ItemsPerPage { get; set; }= 0;

        private int[] _PageItemCount { get; set; }

        public PagnationHelper(IList<T> collection, int itemsPerPage)
        {
            _Collection = (List<T>)collection;
            _ItemsPerPage = itemsPerPage;

            _PageItemCount = new int[PageCount];
            int remainingItems = ItemCount;


            for (int i = 0; i < _PageItemCount.Length; i++)
            {
                if(remainingItems < itemsPerPage) {
                     _PageItemCount[i] = remainingItems;
                }
                else
                {
                    remainingItems = remainingItems - itemsPerPage;
                    _PageItemCount[i] = itemsPerPage;
                }
            }
        }

        public int ItemCount
        {
            get
            {
                return _Collection.Count;
            }
        }

        public int PageCount
        {
            get { return (int)Math.Ceiling(((double) ItemCount / (double) _ItemsPerPage)); }
        }

        public int PageItemCount(int pageIndex)
        {
            if (pageIndex > PageCount - 1 || pageIndex < 0)
            {
                return -1;
            }
            else
            {
                return _PageItemCount[pageIndex];
            }
        }

        public int PageIndex(int ItemIndex)
        {
            if(ItemIndex > ItemCount-1 || ItemIndex < 0) {
                return -1;
            }
            return ItemIndex / _ItemsPerPage;
        }
}