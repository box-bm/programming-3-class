const mathExpresion = "2 + 2 / (1 + 1)";

const validateExpresion = (mathExpresion) => {
  const regex = /^[\d\(\)\[\]\{\}\+\-\/\*]+$/;
  return regex.test(mathExpresion);
};

console.log(validateExpresion(mathExpresion));
