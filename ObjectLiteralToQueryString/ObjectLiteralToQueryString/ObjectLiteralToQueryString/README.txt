https://www.codesai.com/2016/09/kata-object-literal-to-query-string

expect(objectToQueryString("noObject")).toBe("");
expect(objectToQueryString({ })).toBe("");
expect(objectToQueryString({ prop: 'value'})).toBe("prop=value");
expect(objectToQueryString({ prop: 'value', p2: 'v2'})).toBe("prop=value&p2=v2");
expect(objectToQueryString({ p: { p2: 'value'} })).toBe("p[p2]=value");
var obj = {
         prop0: "val0",
         level1: {
            prop1: "val1",
            level2:{
               prop2:"val2"
            }
        }
   };
expect(objectToQueryString(obj)).toBe(
          "prop0=val0&level1[prop1]=value1&level1[level2][prop2]=val2");