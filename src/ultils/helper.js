class HelperMng {
    constructor() {
    }

    isMobileBrowser() {
        if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
            return true
        }

        return false
    }

    setMobileMenu() {
        if (/Android|webOS|iPhone|iPad|iPod|BlackBerry|IEMobile|Opera Mini/i.test(navigator.userAgent)) {
            $('#navbarSupportedContent ul').removeClass('nav')
            $('#navbarSupportedContent ul').addClass('navbar-nav mr-auto')
        } else {
            $('#navbarSupportedContent ul').addClass('nav')
            $('#navbarSupportedContent ul').removeClass('navbar-nav mr-auto')
        }
    }

    isInViewport($selector) {
        var elementTop = $selector.offset().top;
        var elementBottom = elementTop + $selector.outerHeight();

        var viewportTop = $(window).scrollTop();
        var viewportBottom = viewportTop + $(window).height();

        return elementBottom > viewportTop && elementTop < viewportBottom;
    }

    restartAnimate(isActive, $selector, animateClassName) {
        if (isActive) {
            if ($selector.hasClass(animateClassName) == false) {
                setTimeout(function () { $selector.addClass(animateClassName); }, 100)
            }
        } else {
            $selector.removeClass(animateClassName)
        }
    }
}

export default HelperMng;