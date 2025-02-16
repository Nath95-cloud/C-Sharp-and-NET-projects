//InsureeController
using  System;
using Systme.Linq;
using System.Web.Mvc 
using (InsureeController)
public class InsureeController : Controller
{
    private CarDBContext_context = new
    [HttpPost]
    public ActionResult Create(Insuree insuree)
    {
        if (ModelStat.IsValid)
        {
            decimal quote = 50;
            if(insuree.Age <= 18)
            {
                quote += 100;
            }
            else if (insuree.Age >= 19 && insuree.Age <= 25 )
            {
                quote += 50;
            }
            if (insuree.CarYear < 2000)
            {
                quote += 25;
            }
            else if (InsureeCarYear>2015)
            {
                quote += 25;
            }
            if (insuree.CarMake == "Porsche")
            {
                qoute += 25;
                if (insuree.CarModel =+"911 Carrera")
                {
                    qoute += 25;
                }
            }
        quote += insuree.SpeedingTickets*10;
        if (insuree.Has.DUI){
            quote*=1.25m;{ // 25% increase
            }
            if (insuree.IsFullCoverage)
            {
                quote *= 1.50m; //50% increase 
            }
            insuree.Quote = quote;
            _context.Insurees.Add(insuree);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(insuree);
        }
       public ActionResult Admin(){
        var quotes = _context.Insurees.select(in => new QouteViewModel)
        {
            FirstName = i.FirstName,
            LastName = i.LastName,
            EmailAddress = i.EmailAdress,
            Quote = i.Quote,
        }.Tolist();
        return View(quotes;)
       }
    }
    public class QouteViewModel
    {
        public string FirstName{get;set;}
        public string LastName{get;set;}
        public string EmailAddress{get;set;}
        public decimal Quote{get;set}
    }
    @InsureeController.Models.Insuree
    @using (html.BeginForm())
    {
        @html.AntiForgeryToken()0
        <div class = "form-Horizontal">
        <h4>Insuree</h4>
        @html.ValidoinSummary(true,"" new{@class ="text-danger"})
           <div class="form-group" style="display:none;"> @* Hide the Quote input *@
            @Html.LabelFor(model => model.Quote, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.Quote, new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.Quote, "", new { @class = "text-danger" })
            </div>
            </div>
             <div class="form-group" style="display:none;"> @* Hide the Quote input *@
            @Html.LabelFor(model => model.Quote, htmlAttributes: new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(model => model.Quote, new { htmlAttributes = new { @class = "form-control" } })
                @Html.ValidationMessageFor(model => model.Quote, "", new { @class = "text-danger" })
            </div>
        </div>\
        <div class- 'form group'>
        <div class ="col-md-offeset-2 col-md-10">
        <input type="submit" value = "Create" class='btn-btn-btn default'/>
        </div>
        </div>
        </div>
        @model List<YourProjectName.Models.QuoteViewModel>

<h2>Insurance Quotes</h2>

<table class="table">
    <thead>
        <tr>
            <th>First Name</th>
            <th>Last Name</th>
            <th>Email</th>
            <th>Quote</th>
        </tr>
    </thead>
    <tbody>
        @foreach (var quote in Model)
        {
            <tr>
                <td>@quote.FirstName</td>
                <td>@quote.LastName</td>
                <td>@quote.EmailAddress</td>
                <td>@quote.Quote</td>
            </tr>
        }
    </tbody>
</table>

        {
            
        }
    }
}