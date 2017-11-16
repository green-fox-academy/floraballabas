using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BucketListApp.Entities;
using BucketListApp.Models;

namespace BucketListApp.Repositories
{
    public class BucketListRepository
    {
        BucketListContext bucketListContext;

        public BucketListRepository(BucketListContext bucketListContext)
        {
            this.bucketListContext = bucketListContext;
        }

        public List<BucketList> GetList()
        {
            return bucketListContext.BucketLists.ToList();
        }

        public void AddToList(string activity)
        {
            var bucketlist = new BucketList
            {
                Activity = activity
            };
            bucketListContext.Add(bucketlist);
            bucketListContext.SaveChanges();
        }

        public BucketList GetId(int id)
        {
            return bucketListContext.BucketLists.FirstOrDefault(x => id == x.Id);
        }
        public void DeleteItem(int id)
        {
            bucketListContext.BucketLists.Remove(GetId(id));
            bucketListContext.SaveChanges();
        }

        public void UpdateItem(BucketList bucketList)
        {
            bucketListContext.BucketLists.Update(bucketList);
            bucketListContext.SaveChanges();
        }
    }
}
