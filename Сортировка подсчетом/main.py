array = [2, 1, 2, 3, 2, 3]
count = [0, 0, 0, 0, 0, 0]

for i in array:
    print(array[i], end = " ")
    count[array[i]] += 1

print("\n")

for i in range(len(count)):
    print(count[i], end = " ")

k = 0
for i in range(len(array)):
    for j in range(len(count)):
        array[k] = i
        k = k + 1

for i in range(len(array)):
    print(array[i])
