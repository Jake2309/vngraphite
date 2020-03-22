import HelperMng from './ultils/helper'
class TeamManager {
    constructor({ root }) {
        this.$root = $(root);

        this.helper = new HelperMng()
        this.helper.setMobileMenu()

        this.$headerCarousel = $('#team-header-carousel', this.$root)
        this.$ceoContain = $('#ceo-info', this.$root)
        this.$teamLevelContain = $('#team-level', this.$root)

        this.handlerEvent()
    }

    handlerEvent() {
        let self = this

        $(window).scroll(function () {
            let isCarouselActive = self.helper.isInViewport(self.$headerCarousel)
            let animateCarouselText = self.$headerCarousel.find('.text-animate')
            self.helper.restartAnimate(isCarouselActive, animateCarouselText, 'tracking-in-contract-bck-bottom')

            let isCEOActive = self.helper.isInViewport(self.$ceoContain)
            let animateCEOText = self.$ceoContain.find('.text-animate')
            self.helper.restartAnimate(isCEOActive, animateCEOText, 'focus-in-contract-bck')

            let isLevelActive = self.helper.isInViewport(self.$teamLevelContain)

            if (isLevelActive) {
                $('.hexagon-inner-text h1 span').each(function () {
                    let $spanCalculate = $(this)
                    
                    if ($spanCalculate.hasClass('need-calculate') == false) {
                        $spanCalculate.addClass('need-calculate')

                        setTimeout(function () {
                            $spanCalculate.prop('Counter', 0).animate({
                                Counter: $spanCalculate.text()
                            }, {
                                duration: 2000,
                                easing: 'swing',
                                step: function (now) {
                                    let calcVal = Math.ceil(now)

                                    if (calcVal < 10)
                                        $spanCalculate.text('0' + calcVal)
                                    else
                                        $spanCalculate.text(calcVal)
                                }
                            });
                        }, 100)
                    }
                });
            } else {
                $('.hexagon-inner-text h1 span').each(function () {
                    let $spanCalculate = $(this)
                    $spanCalculate.removeClass('need-calculate')
                });
            }
        });
    }
}

const teamMng = new TeamManager({
    root: '#main'
});