using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCoreProje.ViewComponents.Default
{
    public class _Testimonial : ViewComponent
    {
        TestimonialManger testimonialManger = new TestimonialManger(new EfTestimonialDal());
        public IViewComponentResult Invoke()
        {
            var values = testimonialManger.TGetList();
            return View(values);
        }
    }
}
