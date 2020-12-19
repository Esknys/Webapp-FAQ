export class question {
  utData: string;

  constructor(spoersmaal: string, navn: string, epost: string) {
    this.utData = spoersmaal + "  " + navn + "  " + epost;
  }
}

export class InnSpoersmaal {
  Id: number;
  Spoersmaalet: string;
  Navn: string;
  Epost: string;
}
