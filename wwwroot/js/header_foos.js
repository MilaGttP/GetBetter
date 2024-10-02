const btn = document.querySelector('.choose_lang_btn');
const icon = document.querySelector('.lang-btn-icon');

btn.addEventListener('mouseenter', function() {
    icon.classList.add('fade-out');
    setTimeout(function() {
        icon.src = 'assets/lang-hover.svg';
        icon.classList.remove('fade-out');
    }, 300);
});

btn.addEventListener('mouseleave', function() {
    icon.classList.add('fade-out');
    setTimeout(function() {
        icon.src = 'assets/lang.svg';
        icon.classList.remove('fade-out');
    }, 300);
});

const loginBtn = document.querySelector('.login-btn');
const loginIcon = document.querySelector('.login-btn-icon');

loginBtn.addEventListener('mouseenter', function() {
    loginIcon.classList.add('fade-out');
    setTimeout(function() {
        loginIcon.src = 'assets/enter_profile_hover.svg';
        loginIcon.classList.remove('fade-out');
    }, 300);
});

loginBtn.addEventListener('mouseleave', function() {
    loginIcon.classList.add('fade-out');
    setTimeout(function() {
        loginIcon.src = 'assets/enter_profile.svg';
        loginIcon.classList.remove('fade-out');
    }, 300);
});

document.addEventListener('DOMContentLoaded', function () {
    const burgerMenu = document.getElementById('burger-menu');
    const sideMenu = document.getElementById('side-menu');

    function toggleMenu() {
        burgerMenu.classList.toggle('open');
        sideMenu.classList.toggle('open');
    }

    burgerMenu.addEventListener('click', toggleMenu);

    const menuItems = sideMenu.querySelectorAll('ul li a');
    menuItems.forEach(item => {
        item.addEventListener('click', () => {
            burgerMenu.classList.remove('open');
            sideMenu.classList.remove('open');
        });
    });
});

