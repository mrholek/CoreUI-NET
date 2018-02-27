'use strict'

var gulp = require('gulp');
var sass = require('gulp-sass');
var autoprefixer = require('gulp-autoprefixer');
var cssmin = require('gulp-cssmin')
var rename = require('gulp-rename');


gulp.paths = {
  dist: 'wwwroot/',
  src: './'
};

var paths = gulp.paths;

gulp.pkg = require('./package.json');
var pkg = gulp.pkg;

gulp.task('sass', function() {
  return gulp.src(paths.src + '/scss/style.scss')
  .pipe(sass())
  .pipe(autoprefixer())
  .pipe(gulp.dest(paths.dist + 'css'))
  .pipe(cssmin())
  .pipe(rename({suffix: '.min'}))
  .pipe(gulp.dest(paths.dist + 'css'));
});

gulp.task('sass:watch', function() {
  gulp.watch(paths.src + 'scss/**/*.scss', ['sass']);
});

