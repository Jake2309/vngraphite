import HelperMng from './ultils/helper'
class HomeManager {
    constructor({ root }) {
        this.$root = $(root);

        this.helper = new HelperMng()

        this.helper.setMobileMenu()
    }

}

const homeMng = new HomeManager({
    root: '#main'
});