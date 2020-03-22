import HelperMng from './ultils/helper'

class NewsManager {
    constructor({ root }) {
        this.$root = $(root);

        this.helper = new HelperMng()
        this.helper.setMobileMenu()

        this.handleEvent()
    }

    handleEvent() {
        let self = this

    }

}

const newsMng = new NewsManager({
    root: '#main'
});