module.exports = function(grunt){
	grunt.initConfig({
		pkg: grunt.file.readJSON('package.json'),
		jshint:{
			all:['Gruntfile.js', './src/*.js', './test/*.js']
		},
		mochaTest: {
	      test: {
	        options: {
	          reporter: 'spec',
	          clearRequireCache: true
	        },
	        src: ['test/*.js']
	      },
	    },
	    watch:{
			files:'*/*.js',
			tasks:['jshint', 'mochaTest']
		}
	});

	grunt.loadNpmTasks('grunt-contrib-jshint');
	grunt.loadNpmTasks('grunt-mocha-test');
	grunt.loadNpmTasks('grunt-contrib-watch');

	grunt.registerTask('default', ['jshint', 'mochaTest']);
};