const path = require('path');
const webpack = require("webpack");
const outputDir = 'wwwroot/dist';

module.exports = {
    mode: 'development',
    entry: { main: './wwwroot/src/index.js' },
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, outputDir),
        publicPath: '/dist/'
    },
    // This doesn't work with .net
    // scripts: {
    //     watch: "webpack --watch"
    // },
    plugins: [
        //new webpack.HotModuleReplacementPlugin()
        // new webpack.ProvidePlugin({
        //     $: "jquery",
        //     jQuery: "jquery"
        // })
    ],
    // Generates source map for debugging. Don't use this on production.
    devtool: 'eval-source-map'
};