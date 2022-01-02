using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Project.Controllers
{
    public class CartController : Controller
    {
        private readonly DataBasePhatTrienWebContext _context;
        public CartController(DataBasePhatTrienWebContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // Key lưu chuỗi json của Cart
        public const string CARTKEY = "cart";

        // Lấy cart từ Session (danh sách CartItem)
        List<CartItem> GetCartItem()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Xóa cart khỏi session
        void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        // Lưu Cart (Danh sách CartItem) vào session
        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

        /// Thêm sản phẩm vào cart
        [Route("addcart/{ProductID:int}", Name = "addcart")]
        public IActionResult AddToCart([FromRoute] int productid)
        {

            var product = _context.Products
                            .Where(p => p.ProductId == productid)
                            .FirstOrDefault();
            if (product == null)
                if (product == null)
                    return NotFound("Không có sản phẩm");

            // Xử lý đưa vào Cart ...
            var cart = GetCartItem();
            var cartitem = cart.Find(p => p.product.ProductId == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quantity++;
            }
            else
            {
                //  Thêm mới
                cart.Add(new CartItem() { Quantity = 1, product = product });
            }

            // Lưu cart vào Session
            SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(Cart));
        }

        /// xóa item trong cart
        [Route("/removecart/{productid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int productid)
        {
            var cart = GetCartItem();
            var cartitem = cart.Find(p => p.product.ProductId == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        /// Cập nhật
        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int productid, [FromForm] int quantity)
        {
            // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = GetCartItem();
            var cartitem = cart.Find(p => p.product.ProductId == productid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.Quantity = quantity;
            }
            SaveCartSession(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return Ok();
        }

        // Hiện thị giỏ hàng
        [Route("/cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View(GetCartItem());
        }

        [HttpGet]
        public IActionResult Payment()
        {
            var cart = GetCartItem();
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }

        [HttpPost]
        public IActionResult Payment([FromForm] string name, [FromForm] string phone, [FromForm] string email, [FromForm] string address, int count=0)
        {
            // Xử lý khi đặt hàng
            var cart = GetCartItem();
            ViewData["name"] = name;
            ViewData["phone"] = phone;
            ViewData["email"] = email;
            ViewData["address"] = address;
            ViewData["cart"] = cart;

            if (!string.IsNullOrEmpty(email))
            {
                //cấu trúc db lưu lại đơn hàng và xóa cart khỏi session
                using (var context = new DataBasePhatTrienWebContext())
                {
                    var cus = new Customer()
                    {
                        CustomerId = count++,
                        CustomerName = name,
                        CustomerPhone = phone,
                        //OrderDate = DateTime.Now,
                        //OrderId = count++,
                        //OrderShipName = name,
                        //OrderShipPhone = phone,
                        //OrderShipEmail = email,
                        //OrderShipAddress = address,
                        //CustomerId = count++,
                    };
                    context.Customers.Add(cus);
                    context.SaveChanges();
                }
                ClearCart();
                RedirectToAction(nameof(Index));
            }

            return View();

        }
    }
}
