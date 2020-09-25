using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JuiceShopDal;
using JuiceShopEntities;


namespace JuiceShopBusinessManager
{
    public class JuiceshopBusMan
    {
        public List<Juice> GetAllItems()
        {
            Juiceshopdal jsd = new Juiceshopdal();
            List<Juice> lstjuices = jsd.GetJuiceFlavors();
            return lstjuices;
        }
        public void PurchasedJuice(int juice_id, int quantity)
        {
            Juiceshopdal jsd = new Juiceshopdal();
            jsd.JuicePurchased(juice_id,quantity);
        }
        public List<JuicePurchased> GetAllPurchasedItems()
        {
            Juiceshopdal jsd = new Juiceshopdal();
            List<JuicePurchased> lstjucpur = jsd.GetJuicePurchased();
            return lstjucpur;
        }
        public void DeletePreviosPurchases()
        {
            Juiceshopdal jsd = new Juiceshopdal();
            jsd.DeleteRecords();
        }
    }
}
