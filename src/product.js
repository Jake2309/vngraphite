import HelperMng from './ultils/helper'
import 'bootstrap/js/dist/carousel'

class ProductManager {
    constructor({ root }) {
        this.$root = $(root);

        this.helper = new HelperMng()
        this.helper.setMobileMenu()

        this.$carousel = $('.carousel', this.$root)
        this.$pillTab = $('#pills-tab', this.$root)

        this.$floatTab = $('#pills-up-prd-tab', this.$root)
        this.$deepTab = $('#pills-deep-prd-tab', this.$root)

        this.handleEvent()
    }

    handleEvent() {
        let self = this

        self.$carousel.carousel({
            interval: false
        })

        self.$deepTab.on('click', function () {
            self.$carousel.carousel('next')
        })

        self.$floatTab.on('click', function () {
            self.$carousel.carousel('prev')
        })
    }

}

const prdMng = new ProductManager({
    root: '#main'
});