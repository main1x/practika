SELECT SUM(Py.summary_payment - Py.year_pay) AS debt
FROM Paying Py
JOIN Apartments A ON Py.apartament_id = A.apartament_id
JOIN Payment P ON Py.payment_id = P.payment_id
WHERE A.house_number = 5
  AND A.apartament_number = 512
  AND P.type = 'теплоснабжение';