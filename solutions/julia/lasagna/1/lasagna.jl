# Define the `expected_bake_time` constant`
const expected_bake_time::Int = 60

# Define the `preparation_time(layers)` function.
function preparation_time(layers::Int)
    return 2*layers
end

# Define the `remaining_time(time_in_oven)` function.
function remaining_time(time_in_oven::Int)
    return expected_bake_time - time_in_oven
end

# Define the `total_working_time(layers, time_in_oven)` function.
function total_working_time(layers::Int, time_in_oven::Int)
    return preparation_time(layers) + time_in_oven
end