const merge = require('webpack-merge');
const common = require('./webpack.common.js');
const CopyWebpackPlugin = require('copy-webpack-plugin');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');

module.exports = merge(common, {
    mode: 'production',
    plugins: [
        new CleanWebpackPlugin(),
        new CopyWebpackPlugin([
            { from: 'src/appstrap/assets/img', to: 'images/appstrap/img' },
            { from: 'src/appstrap/assets/favicons', to: 'images/appstrap/favicons' },
            { from: 'src/images', to: 'images' }
        ])
    ],
    //performance: {
    //    hints: 'warning'
    //},
    //output: {
    //    pathinfo: false
    //},
    //optimization: {
    //    namedModules: false,
    //    namedChunks: false,
    //    nodeEnv: 'production',
    //    flagIncludedChunks: true,
    //    occurrenceOrder: true,
    //    sideEffects: true,
    //    usedExports: true,
    //    concatenateModules: true,
    //    splitChunks: {
    //        hidePathInfo: true,
    //        minSize: 30000,
    //        maxAsyncRequests: 5,
    //        maxInitialRequests: 3,
    //    },
    //    noEmitOnErrors: true,
    //    checkWasmTypes: true,
    //    minimize: true,
    //},
    //plugins: [
    //    new TerserPlugin(/* ... */),
    //    new webpack.DefinePlugin({ "process.env.NODE_ENV": JSON.stringify("production") }),
    //    new webpack.optimize.ModuleConcatenationPlugin(),
    //    new webpack.NoEmitOnErrorsPlugin()
    //]
});