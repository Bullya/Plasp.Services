require.config({
    baseUrl: '../',
    //urlArgs: 'v=' + (new Date()).getTime(),
    waitSeconds: 30,
    paths: {
        'jquery': 'lib/jquery/dist/jquery-1.9.1.min',
        'bootstrap': 'js/bootstrap.min',
        'md5': 'js/md5',
        'sidebar': 'js/sidebar-menu',
        'bootstrap-tab': 'js/bootstrap-tab',
        'ace': 'js/ace.min',
        'ace-extra': 'js/ace-extra.min',
        'public': 'js/public',
        'css': 'js/require-css'
    },
    shim: {
        'bootstrap': {
            deps: ['jquery']
        },
        'bootstrap-tab': {
            deps: ['jquery']
        },
        'ace': {
            deps: [
                'jquery',
                'css!../css/ace-rtl.min.css',
                'css!../css/ace-skins.min.css'
            ]
        },
        'sidebar': {
            deps: ['jquery']
        }
    }
})