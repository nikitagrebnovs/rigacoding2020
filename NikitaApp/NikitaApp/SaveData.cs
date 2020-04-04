using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NikitaApp
{
    public class SaveData
    {
        public String object_id, object_date, object_adress, object_kilometres, object_Owener, object_Mobile, object_status, object_Works;

        public SaveData(String object_id, String object_date, String object_adress, String object_kilometres, String object_Owener, String object_Mobile,String object_status, String object_Works)
        {
            this.object_id = object_id;
            this.object_date = object_date;
            this.object_adress = object_adress;
            this.object_kilometres = object_kilometres;
            this.object_Owener = object_Owener;
            this.object_Mobile = object_Mobile;
            this.object_status = object_status;
            this.object_Works = object_Works;


        }

        public String GetId()
        {
            return object_id;
        }
        public void SetId(String object_id)
        {
            this.object_id = object_id;
        }

        public String GetDate()
        {
            return object_date;
        }
        public void SetDate(String object_date)
        {
            this.object_date = object_date;
        }

        public String GetSAdress()
        {
            return object_adress;
        }
        public void SetAdress(String object_adress)
        {
            this.object_adress = object_adress;
        }

        public String GetKm()
        {
            return object_kilometres;
        }
        public void SetKm(String object_kilometres)
        {
            this.object_kilometres = object_kilometres;
        }

        public String GetOwner()
        {
            return object_Owener;
        }
        public void SetOwner(String object_Owener)
        {
            this.object_Owener = object_Owener;
        }


        public String GetMobile()
        {
            return object_Mobile;
        }
        public void SetMobile(String object_Mobile)
        {
            this.object_Mobile = object_Mobile;
        }

        public String GetStatus()
        {
            return object_status;
        }
        public void SetStatus(String object_status)
        {
            this.object_status = object_status;
        }


        public String GetWorks()
        {
            return object_Works;
        }
        public void SetWorks(String object_Works)
        {
            this.object_Works = object_Works;
        }



    }
}
