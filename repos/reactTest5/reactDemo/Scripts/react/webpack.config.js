module.exports = {
    mode: 'development',
    context: __dirname,
    entry: {
        app: "./app.js",
        app1: "./app1.js"
    },

        //["./app.js", "./app1.js"],
    output: {
        path: __dirname + "/dist",
        filename: "bundle.js"
    },
    watch: true,
    module: {
        rules: [
            {
                test: /\.js$/,
                exclude: /(node_modules)/,
                use: {
                    loader: 'babel-loader',
                    options: {
                        presets: ['babel-preset-env', 'babel-preset-react']
                    }
                }
            }
        ]
    }
}