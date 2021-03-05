using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication4;

namespace WebApplication4.Controllers
{
    public class BrokerTablesController : Controller
    {
        private Entities1 db = new Entities1();

        // GET: BrokerTables
        public async Task<ActionResult> Index()
        {
            return View(await db.BrokerTables.ToListAsync());
        }

        // GET: BrokerTables/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrokerTable brokerTable = await db.BrokerTables.FindAsync(id);
            if (brokerTable == null)
            {
                return HttpNotFound();
            }
            return View(brokerTable);
        }

        // GET: BrokerTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrokerTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "BrokerId,FirstName,LastName,City,Address,MobileNumber,RegistrationDate,Status")] BrokerTable brokerTable)
        {
            if (ModelState.IsValid)
            {
                db.BrokerTables.Add(brokerTable);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(brokerTable);
        }

        // GET: BrokerTables/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrokerTable brokerTable = await db.BrokerTables.FindAsync(id);
            if (brokerTable == null)
            {
                return HttpNotFound();
            }
            return View(brokerTable);
        }

        // POST: BrokerTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "BrokerId,FirstName,LastName,City,Address,MobileNumber,RegistrationDate,Status")] BrokerTable brokerTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brokerTable).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(brokerTable);
        }

        // GET: BrokerTables/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BrokerTable brokerTable = await db.BrokerTables.FindAsync(id);
            if (brokerTable == null)
            {
                return HttpNotFound();
            }
            return View(brokerTable);
        }

        // POST: BrokerTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            BrokerTable brokerTable = await db.BrokerTables.FindAsync(id);
            db.BrokerTables.Remove(brokerTable);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
