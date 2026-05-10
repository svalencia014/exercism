func dailyRateFrom(hourlyRate: Int) -> Double {
  return 8.0 * Double(hourlyRate)
}

func monthlyRateFrom(hourlyRate: Int, withDiscount discount: Double) -> Double {
  let daily = dailyRateFrom(hourlyRate: hourlyRate)

  return ((daily * 22) - (daily * 22 * (discount/100))).rounded()
}

func workdaysIn(budget: Double, hourlyRate: Int, withDiscount discount: Double) -> Double {
  return (budget / (dailyRateFrom(hourlyRate: hourlyRate) * (1 - discount * 0.01))).rounded(.down)
}
