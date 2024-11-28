SELECT SUM(P.price_per_square * A.square + P.price_per_person * A.peoples_count) AS total_monthly_payment
FROM Apartments A
JOIN Paying Py ON A.apartament_id = Py.apartament_id
JOIN Payment P ON Py.payment_id = P.payment_id
WHERE A.house_number = 5;