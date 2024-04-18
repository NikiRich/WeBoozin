let img1 = document.getElementById("AlcMng")
let img2 = document.getElementById("OrderMng")
let img3 = document.getElementById("UserMng")

img1.addEventListener("click", function () {
    window.location.href = "/UserLogic/Admin/ProductManagement";
})

img2.addEventListener("click", function () {
    window.location.href = "/UserLogic/Admin/OrderManagement";
})

img3.addEventListener("click", function () {
    window.location.href = "/UserLogic/Admin/UserManagement";
})