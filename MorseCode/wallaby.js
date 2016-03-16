module.exports = () => {
  return {
    files: [
      'src/*.js'
    ],
    tests: [
      'spec/*Spec.js'
    ],
    debug: true,
    "testFramework": "jasmine@2.3.4"
  };
};
