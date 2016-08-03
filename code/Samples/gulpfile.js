/// <binding AfterBuild='css:scss' ProjectOpened='watch:scss' />
/*
This file in the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. http://go.microsoft.com/fwlink/?LinkId=518007
*/

var gulp = require('gulp');
var sass = require('gulp-sass');

gulp.task('css:scss', function () {
    gulp.src('styles/**/*.scss')
        .pipe(sass().on('error', sass.logError))
        .pipe(gulp.dest('./wwwroot/css/'));
});

gulp.task('watch:scss', function () {
	gulp.watch('styles/**/*.scss', ['css:scss']);
});