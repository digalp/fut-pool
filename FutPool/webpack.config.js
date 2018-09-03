const path = require('path');
const webpack = require("webpack");
const outputDir = 'wwwroot/dist';

module.exports = {
    //target: 'web',
    mode: 'development',
    entry: { main: './wwwroot/src/index.js' },
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, outputDir),
        publicPath: '/dist/'
    },
    plugins: [
        new webpack.HotModuleReplacementPlugin()
        // new webpack.ProvidePlugin({
        //     $: "jquery",
        //     jQuery: "jquery"
        // })
    ]
};