const path = require('path');
const webpack = require("webpack");

module.exports = {
    entry: {
        'index': ['./src/index.js', './src/sass/index.scss'],
        'appstrap-script': ['./src/appstrap/js/appstrap-script.js', './src/appstrap/sass/appstrap-theme.scss'],
        'card-gallery': ['./src/css/cards-gallery.css'],
        'home-mng': ['./src/home.js'],
        'general-info': ['./src/general-info.js'],
        'team-mng': ['./src/team.js'],
        'product-mng': ['./src/product.js'],
        'partner-mng': ['./src/partner.js'],
        'news-mng': ['./src/news-mng.js'],
    },
    output: {
        filename: '[name].bundle.js',
        chunkFilename: '[name].bundle.js',
        //production
        //filename: '[contenthash].js',
        //chunkFilename: '[contenthash].js',
        path: path.resolve(__dirname, 'wwwroot/dist'),
        publicPath: "/dist/"
    },
    plugins: [
        new webpack.ProvidePlugin({
            jQuery: 'jquery',
            $: 'jquery',
            jquery: 'jquery',
            'window.jQuery': 'jquery',
            //Alert: 'exports-loader?Alert!bootstrap/js/dist/alert',
            //Button: 'exports-loader?Button!bootstrap/js/dist/button',
            //Carousel: 'exports-loader?Carousel!bootstrap/js/dist/carousel',
            //Collapse: 'exports-loader?Collapse!bootstrap/js/dist/collapse',
            //Dropdown: 'exports-loader?Dropdown!bootstrap/js/dist/dropdown',
            //Modal: 'exports-loader?Modal!bootstrap/js/dist/modal',
            //Popover: 'exports-loader?Popover!bootstrap/js/dist/popover',
            //Scrollspy: 'exports-loader?Scrollspy!bootstrap/js/dist/scrollspy',
            //Tab: 'exports-loader?Tab!bootstrap/js/dist/tab',
            //Tooltip: "exports-loader?Tooltip!bootstrap/js/dist/tooltip",
            //Util: 'exports-loader?Util!bootstrap/js/dist/util'
        })
    ],
    module: {
        rules: [
            {
                test: /\.(scss|sass|css)$/,
                use: [
                    {
                        loader: 'file-loader',
                        options: {
                            name: '[name].bundle.css'
                            // production
                            //name: '[contenthash].css'
                        }
                    },
                    {
                        loader: 'extract-loader'
                    },
                    {
                        loader: "css-loader",
                        //options: {
                        //    minimize: true || {/* or CSSNano Options see http://cssnano.co/guides/ */ }
                        //}
                    },
                    {
                        loader: "sass-loader"
                    }
                ]
            }
        ]
    }
};