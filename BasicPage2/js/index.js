var burgerBtn = document.getElementById(`burger-btn`);
var navItems = document.getElementById(`nav-items`);

var isOpened = false;

burgerBtn.addEventListener("click", () => {
  if (isOpened == false) {
    navItems.style.display = `block`;
    navItems.classList.add(`slide-bottom`);
    isOpened = true;
  } else {
    navItems.style.display = `none`;
    navItems.classList.remove(`slide-bottom`);
    isOpened = false;
  }
});
