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
    public class PropertyTablesController : Controller
    {
        private Entities db = new Entities();

        // GET: PropertyTables
        public async Task<ActionResult> Index()
        {
            return View(await db.PropertyTables.ToListAsync());
        }

        // GET: PropertyTables/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyTable propertyTable = await db.PropertyTables.FindAsync(id);
            if (propertyTable == null)
            {
                return HttpNotFound();
            }
            return View(propertyTable);
        }

        // GET: PropertyTables/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyTables/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,PropertyType,PropertyCatagory,Address,City,Location,Status,Price,Size,Image")] PropertyTable propertyTable)
        {
            if (ModelState.IsValid)
            {
                db.PropertyTables.Add(propertyTable);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(propertyTable);
        }

        // GET: PropertyTables/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyTable propertyTable = await db.PropertyTables.FindAsync(id);
            if (propertyTable == null)
            {
                return HttpNotFound();
            }
            return View(propertyTable);
        }

        // POST: PropertyTables/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,PropertyType,PropertyCatagory,Address,City,Location,Status,Price,Size,Image")] PropertyTable propertyTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propertyTable).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(propertyTable);
        }

        // GET: PropertyTables/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyTable propertyTable = await db.PropertyTables.FindAsync(id);
            if (propertyTable == null)
            {
                return HttpNotFound();
            }
            return View(propertyTable);
        }

        // POST: PropertyTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            PropertyTable propertyTable = await db.PropertyTables.FindAsync(id);
            db.PropertyTables.Remove(propertyTable);
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
