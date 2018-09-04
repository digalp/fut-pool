const path = require('path');
const webpack = require("webpack");
const VueLoaderPlugin = require('vue-loader/lib/plugin')
const outputDir = 'wwwroot/dist';

module.exports = {
    mode: 'development',
    entry: { main: './wwwroot/src/index.js' },
    //entry: { main: ['./wwwroot/src/index.js', 'webpack-hot-middleware/client'] },
    output: {
        filename: 'bundle.js',
        path: path.resolve(__dirname, outputDir),
        publicPath: '/dist/'
    },
    module: {
        rules: [
            {
                test: /\.vue$/,
                loader: 'vue-loader'
            },
            // this will apply to both plain `.js` files
            // AND `<script>` blocks in `.vue` files
            {
                test: /\.js$/,
                loader: 'babel-loader'
            },
            // this will apply to both plain `.css` files
            // AND `<style>` blocks in `.vue` files
            {
                test: /\.css$/,
                use: [
                    'vue-style-loader',
                    'css-loader'
                ]
            }
        ]
    },
    resolve: {
        alias: {
            'vue$': 'vue/dist/vue.esm.js'
        },
        extensions: ['*', '.js', '.vue', '.json']
    },
    // This doesn't work with .net
    // scripts: {
    //     watch: "webpack --watch"
    // },
    plugins: [
        new VueLoaderPlugin()
        //new webpack.HotModuleReplacementPlugin()
        // new webpack.ProvidePlugin({
        //     $: "jquery",
        //     jQuery: "jquery"
        // })
    ],
    // Generates source map for debugging. Don't use this on production.
    devtool: 'eval-source-map'
};