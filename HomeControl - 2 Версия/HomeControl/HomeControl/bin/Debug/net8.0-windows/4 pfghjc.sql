SELECT A.apartament_number
FROM Apartments A
JOIN Paying Py ON A.apartament_id = Py.apartament_id
WHERE Py.summary_payment = Py.year_pay;
