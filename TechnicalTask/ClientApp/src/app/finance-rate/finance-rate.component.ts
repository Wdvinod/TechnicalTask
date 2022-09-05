import { Component } from '@angular/core';
import { SharedService } from '../shared.service';
@Component({
    selector: 'app-finance-rate',
    templateUrl: './finance-rate.component.html',
    styleUrls: ['./finance-rate.component.css']
})
export class FinanceRateComponent {
    constructor(private SharedService: SharedService) { }
    financeRates: Array<any> = [];
    financeRateTypes: any;
    ngOnInit(): void {

        this.getFinanceRateTypes();
    }
    getFinanceRates() {
        this.SharedService.getFinanceRates().subscribe((rates: Rates[]) => {
            for (var i = 0; i < rates.length; i++) {
                var obj = { "Make": rates[i].Make.Name, "VehicleType": rates[i].VehicleType.Type, "FinanceType": rates[i].FinanceType.Type };
                for (var j = 0; j < this.financeRateTypes.length; j++) {
                    obj["rate" + this.financeRateTypes[j].Id] = "-";
                }
                for (var k = 0; k < rates[i].FinanceRates.length; k++) {
                    obj["rate" + rates[i].FinanceRates[k].FinanceRateTypeId] = rates[i].FinanceRates[k].Rate;
                }
                console.log(obj);
                this.financeRates.push(obj);
            }
            
        })
    }
    getFinanceRateTypes() {
        this.SharedService.getFinanceTypes().subscribe((data: any[]) => {
            this.financeRateTypes = data;
            console.log(this.financeRateTypes);
            this.getFinanceRates();
        })
    }
}

interface Rates {
    Id: number;
    Make: Make;
    VehicleType: VehicleType;
    FinanceType: FinanceType;
    FinanceRates: Array<FinancRates>;
}

interface Make {
    Id: number;
    Name: string;
}
interface VehicleType {
    Id: number;
    Type: string;
}
interface FinanceType {
    Id: number;
    Type: string;
}

interface FinancRates {
    Id: number;
    FinanceRateTypeId: number;
    Rate: number;
}