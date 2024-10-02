// Q/A EXPANDING

document.querySelectorAll('.qas-item').forEach(item => {
    item.addEventListener('click', function() {
        this.classList.toggle('expanded');
    });
});


// FEEDBACKS CAROUSEL

var swiper = new Swiper('.swiper-container-fb', {
    loop: true,
    autoplay: {
        delay: 3000, 
        disableOnInteraction: false,
    },
    speed: 600,
    spaceBetween: 15,
    breakpoints: {
        320: {
            slidesPerView: 1,
            spaceBetween: 10,
        },
        480: {
            slidesPerView: 1,
            spaceBetween: 10,
        },
        768: {
            slidesPerView: 2,
            spaceBetween: 15,
        },
        1024: {
            slidesPerView: 2,
            spaceBetween: 15,
        },
        1200: {
            slidesPerView: 3,
            spaceBetween: 15,
        }
    }
});


// NEWS CAROUSEL

var swiper = new Swiper('.news-items', {
    loop: true,
    autoplay: {
        delay: 5000,
        disableOnInteraction: false,
    },
    speed: 600,
    navigation: {
        nextEl: '.swiper-news-button-next',
        prevEl: '.swiper-news-button-prev',
    },
    slidesPerView: 'auto', 
    centeredSlides: true,
    spaceBetween: 20,
});


// TEACHERS CAROUSEL

var swiper = new Swiper('.swiper-container-teach', {
    loop: true,
    autoplay: {
        delay: 4000,
        disableOnInteraction: false,
    },
    slidesPerView: 'auto', 
    centeredSlides: true,
    speed: 600,
    navigation: {
        nextEl: '.swiper-teach-button-next',
        prevEl: '.swiper-teach-button-prev',
    },
    spaceBetween: 35,
    on: {
        init: function () {
            this.slides.forEach(slide => {
                slide.style.width = '300px';
            });
        }
    }
});


// TEACHER FILTER BUTTON

const filter_buttons = document.querySelectorAll('.choose-item');

filter_buttons.forEach(function(filter_button) {
    const filter_icon = filter_button.querySelector('.choose-item-img');
    let isClicked = false;

    filter_button.addEventListener('mouseenter', function() {
        if (!isClicked) {
            filter_icon.classList.add('fade-out');
            setTimeout(function() {
                filter_icon.src = 'assets/t-filter-circle-checked.svg';
                filter_icon.classList.remove('fade-out');
            }, 200);
        }
    });

    filter_button.addEventListener('mouseleave', function() {
        if (!isClicked) {
            filter_icon.classList.add('fade-out');
            setTimeout(function() {
                filter_icon.src = 'assets/t-filter-circle-nchecked.svg';
                filter_icon.classList.remove('fade-out');
            }, 200);
        }
    });

    filter_button.addEventListener('click', function() {
        if (isClicked) {
            filter_icon.src = 'assets/t-filter-circle-nchecked.svg';
            isClicked = false;
        } else {
            filter_icon.src = 'assets/t-filter-circle-checked.svg';
            isClicked = true;
        }
    });
});


// COST CAROUSEL

var swiper = new Swiper('.cost-items-div', {
    loop: true,
    autoplay: {
        delay: 4000, 
        disableOnInteraction: false,
    },
    speed: 500,
    spaceBetween: 20,
    navigation: {
        nextEl: '.swiper-cost-button-next',
        prevEl: '.swiper-cost-button-prev',
    },
    slidesPerView: 3,
    breakpoints: {
        320: {
            slidesPerView: 1,
            spaceBetween: 20,
        },
        480: {
            slidesPerView: 1,
            spaceBetween: 20,
        },
        768: {
            slidesPerView: 2,
            spaceBetween: 20,
        },
        1200: {
            slidesPerView: 3,
            spaceBetween: 20,
        }
    },
    on: {
        init: function () {
            this.slides.forEach(slide => {
                slide.style.width = '380px';
            });
        }
    }
});